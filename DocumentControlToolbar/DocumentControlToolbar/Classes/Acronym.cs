﻿using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;
using System.Net;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Drawing;


namespace DocumentControlToolbar {

    class AcronymTableTool {
        private Word.Application app = Globals.ThisAddIn.Application;

        private Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;

        private Dictionary<string, String> wordlist = new Dictionary<string, String>();

        /** This is a test of javadoc. **/
        private HashSet<String> found = new HashSet<String>();

        private HashSet<String> notAcronyms = new HashSet<String>();

        private HashSet<String> inTable = new HashSet<String>();

        private Word.Table acronymTable;

        private AcronymTableLoadingForm frm;

        public AcronymTableTool() {
            try {
                acronymTable = FindAcronymTable();

                using (frm = new AcronymTableLoadingForm(Start)) {
                    frm.ShowDialog();
                }
            } catch (CustomExceptions) {
                MessageBox.Show("The acronym table could not be found.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /** Locates the acronym table in the document and returns it. **/
        private Word.Table FindAcronymTable() {
            Word.Range word = doc.Words[1];

            foreach (Word.Table table in doc.Tables) {
                String[] possibilities = { "Abbreviations", "Abbreviation", "Acronym", "Acronyms" };

                String topLeft = table.Cell(1, 1).Range.Text;

                foreach (String s in possibilities) {
                    if (topLeft.Remove(topLeft.Length - 2).Trim().Equals(s)) {
                        return table;
                    }
                }
            }

            throw new CustomExceptions("The acronym table could not be found.");
        }

        private void Start() {
            // Load all of the wordlists for later use.
            for (int i = 97; i <= 122; i++) {
                char character = (char)i;
                String text = character.ToString();

                wordlist.Add(text, DownloadWordlist(text));
            }

            CheckAcronymsInTable();
            GetAllAcronymsInDocument();
            AddFoundAcronymsToTable();
        }

        /** Checks if the acronyms in the table appear in the rest of the document. **/
        private void CheckAcronymsInTable() {

            frm.SetMainText("Checking acronyms in the table.");

            int numRows = acronymTable.Rows.Count;
            int currentItem = 0;

            for (int i = 2; i <= numRows; i++) {
                SetNumber(currentItem++, numRows);

                Word.Cell leftCell = acronymTable.Cell(i, 1);
                Word.Cell rightCell = acronymTable.Cell(i, 2);

                String acronym = leftCell.Range.Text;
                acronym = acronym.Remove(acronym.Length - 2);
                SearchForEntry(leftCell, acronym);

                String definition = rightCell.Range.Text;
                definition = definition.Remove(definition.Length - 2);
                SearchForEntry(rightCell, definition);

                inTable.Add(acronym.Trim());
            }
        }

        /** Searches if this cell's acronym appears in the document **/
        private Boolean SearchForEntry(Word.Cell thisCell, String text) {
            Boolean found = true;

            thisCell.Range.Text = "";

            if (!Find(text, false)) {
                thisCell.Shading.ForegroundPatternColorIndex = Word.WdColorIndex.wdRed;
                found = false;
            }

            thisCell.Range.Text = text;

            return found;
        }

        /** Searches through the active document for a string. Returns true if found; else, false. **/
        private Boolean Find(String text, Boolean matchCase) {
            Word.Find thisFind = doc.Content.Find;
            thisFind.Text = text;
            thisFind.Format = false;
            thisFind.Wrap = Word.WdFindWrap.wdFindContinue;
            thisFind.MatchCase = matchCase;
            thisFind.MatchWholeWord = true;

            return thisFind.Execute();
        }

        /** Searches through the document for words it thinks might be an acronym. **/
        private void GetAllAcronymsInDocument() {
            //Stopwatch stopWatch = new Stopwatch();
            //stopWatch.Start();

            frm.SetMainText("Checking all words in document.");


            int allWords = doc.Words.Count;
            int currentItem = 0;

            foreach (Word.Range word in doc.Words) {
                SetNumber(currentItem++, allWords);

                if (IsValidWordFirstCheck(word.Text)) {
                    if (!app.CheckSpelling(word.Text.ToLower())) {
                        found.Add(word.Text.Trim());
                        if (!notAcronyms.Contains(word.Text)) {
                            if (IsValidWordFirstCheck(word.Text)) {
                                if (!app.CheckSpelling(word.Text.ToLower())) {
                                    found.Add(word.Text.Trim());
                                } else {
                                    notAcronyms.Add(word.Text);
                                }
                            } else {
                                notAcronyms.Add(word.Text);
                            }
                        }
                    }

                    //stopWatch.Stop();
                    //Debug.Print(stopWatch.ElapsedMilliseconds.ToString());
                }
            }
        }

        /** The first check to determine if a given string is a valid acronym. **/
        private Boolean IsValidWordFirstCheck(String s) {
            //TODO this will not work for things like '3G'
            return s != null && s.Trim().Length > 1 && s.ToUpper().Equals(s);
        }

        /** Adds all found acronyms (that are not already in the table) to the table; then, sort. **/
        private void AddFoundAcronymsToTable() {
            frm.SetMainText("Adding all found acronyms to the table.");

            String dudsList = GetDudsList();

            int allFoundWords = found.Count;
            int currentItem = 0;

            foreach (String word in found) {
                SetNumber(currentItem++, allFoundWords);
                
                String definition = "";

                if (!inTable.Contains(word.Trim()) && !dudsList.Contains(word.Trim())) {
                    acronymTable.Rows.Add();

                    Word.Cell acronymCell = acronymTable.Cell(acronymTable.Rows.Count, 1);
                    acronymCell.Shading.ForegroundPatternColorIndex = Word.WdColorIndex.wdYellow;
                    acronymCell.Range.Text = word;

                    String letter = word.ToLower().Substring(0, 1);

                    if (wordlist[letter].Contains(word.Trim())) {
                        foreach (string s in wordlist[letter].Split('\n')) {
                            String[] split = s.Split(',');

                            if (split[0].Equals(word.Trim())) {
                                definition = split[1].Trim();
                            }
                        }
                    }

                    Word.Cell defCell = acronymTable.Cell(acronymTable.Rows.Count, 2);
                    defCell.Shading.ForegroundPatternColorIndex = Word.WdColorIndex.wdYellow;
                    defCell.Range.Text = definition;
                }
            }

            acronymTable.SortAscending();
        }

        /** Loads a wordlist from its location in AppData. **/
        private String DownloadWordlist(String beginningLetter) {
            String appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            String docCont = Path.Combine(appData, "DocumentControl");
            String wordLoc = Path.Combine(docCont, beginningLetter + ".csv");

            return System.IO.File.ReadAllText(wordLoc);
        }

        /** Loads the duds list from its location in AppData. **/
        private String GetDudsList() {
            return DownloadWordlist("acronym-duds");
        }

        private void SetNumber(int current, int total) {
            frm.SetNumberingUpdate(current + " of " + total);
        }
    }
}
