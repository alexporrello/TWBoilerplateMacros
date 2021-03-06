﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Tools;
using Word = Microsoft.Office.Interop.Word;
using System.Diagnostics;
using System.Collections;
using System.Net;
using System.Windows.Forms;

namespace DocumentControlToolbar {
    public partial class DocumentControlRibbon {

        Word.Application app;

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e) {
            app = Globals.ThisAddIn.Application;
        }

        /** ======================= General Group ======================= **/

        private void docPropUpdater_Click(object sender, RibbonControlEventArgs e) {
            new DocPropertiesEditor().Show();
        }

        private void showMarkup_Click(object sender, RibbonControlEventArgs e) {
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            doc.ActiveWindow.ActivePane.View.ShowAll = showMarkup.Checked;
        }

        /** ======================= Style Tools Group ======================= **/

        private void insertSectionBreak_Click(object sender, RibbonControlEventArgs e) {
            app.Selection.InsertBreak(Word.WdBreakType.wdSectionBreakNextPage);
        }

        private void headings_Click(object sender, RibbonControlEventArgs e) {
            Tools.LoadNormalTemplate();
        }

        private void applyBodyStyle_Click(object sender, RibbonControlEventArgs e) {
            Tools.SetStyle("2016_Bodytext | 9pt");
        }

        private void applyMarkingStyle_Click(object sender, RibbonControlEventArgs e) {
            Tools.SetStyle("2016_Marking");
        }

        private void applyFigureStyle_Click(object sender, RibbonControlEventArgs e) {
            Tools.SetStyle("2016_Figure");
        }

        private void keepWithNext_Click(object sender, RibbonControlEventArgs e) {
            app.Selection.ParagraphFormat.KeepWithNext = -1;
        }

        private void formatAllFigures_Click(object sender, RibbonControlEventArgs e) {
            DocControlLoadingForm form;

            using (form = new DocControlLoadingForm(FormatAllFigures, "Formatting all figures.")) {
                form.ShowDialog();
            }
        }

        private void FormatAllFigures() {
            Tools.StartWait();

            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;

            foreach (Word.InlineShape shape in doc.InlineShapes) {
                shape.Select();
                Tools.SetStyle("2016_Figure");
            }

            Tools.EndWait();
        }

        private void pageBreakBefore_Click(object sender, RibbonControlEventArgs e) {
            app.Selection.ParagraphFormat.PageBreakBefore = -1;
        }

        /** ======================= List Tools Group ======================= **/

        private void defaultUL_Click(object sender, RibbonControlEventArgs e) {
            Tools.SetStyle("Body Text enumeration Arrow 2016 black");
        }

        private void defaultOL_Click(object sender, RibbonControlEventArgs e) {
            Tools.SetStyle("Body Text enumeration1 1. 2. 3.");
        }

        /** ======================= Acronym Table Group ======================= **/

        private void formatTable_Click(object sender, RibbonControlEventArgs e) {
            Tools.StartWait();

            DocControlLoadingForm form;

            using (form = new DocControlLoadingForm(Tools.FormatTable, "Formatting table.")) {
                form.ShowDialog();
            }

            Tools.EndWait();
        }

        private void runAcronymTool_Click(object sender, RibbonControlEventArgs e) {
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;

            Boolean trackChanges = doc.TrackRevisions;
            doc.TrackRevisions = false;
            new AcronymTableTool();
            doc.TrackRevisions = trackChanges;
        }

        /** ======================= Cross-references Group ======================= **/

        private void tableRefButton_Click(object sender, RibbonControlEventArgs e) {
            app.Selection.InsertCaption("Table", "", "InsertCaption2", Word.WdCaptionPosition.wdCaptionPositionAbove, 0);
            app.Selection.ParagraphFormat.set_Style(app.ActiveDocument.Styles["2016_Marking"]);
        }

        private void figureRefButton_Click(object sender, RibbonControlEventArgs e) {
            app.Selection.InsertCaption("Figure", "", "InsertCaption2", Word.WdCaptionPosition.wdCaptionPositionAbove, 0);
            app.Selection.ParagraphFormat.set_Style(app.ActiveDocument.Styles["2016_Marking"]);
        }

        /** ======================= Headings Dropdown ======================= **/

        private void headingOne_Click(object sender, RibbonControlEventArgs e) {
            Tools.SetStyle("Heading 1,2016_Überschrift 1,Headline 1");
        }

        private void headingTwo_Click(object sender, RibbonControlEventArgs e) {
            Tools.SetStyle("Heading 2,2016_Überschrift 2,Headline 2");
        }

        private void headingThree_Click(object sender, RibbonControlEventArgs e) {
            Tools.SetStyle("Heading 3,2016_Überschrift 3,Headline 3");
        }

        private void headingFour_Click(object sender, RibbonControlEventArgs e) {
            Tools.SetStyle("Heading 4,2016_Überschrift 4,Headline 4");
        }

        private void headingFive_Click(object sender, RibbonControlEventArgs e) {
            Tools.SetStyle("Heading 5,2016_Überschrift 5,Headline 5");
        }

        /** ======================= Ordered List Dropdown v2.0 ======================= **/

        private void level_one_ol_Click(object sender, RibbonControlEventArgs e) {
            Tools.SetStyle("Body Text enumeration1 1. 2. 3.");
        }

        private void level_two_ol_Click(object sender, RibbonControlEventArgs e) {
            Tools.SetStyle("Body Text enumeration2 a)b)c)");
        }

        /** ======================= Unordered List Dropdown v2.0 ======================= **/

        private void level_one_uo_Click(object sender, RibbonControlEventArgs e) {
            Tools.SetStyle("Body Text enumeration Arrow 2016 black");
        }

        private void level_two_uo_Click(object sender, RibbonControlEventArgs e) {
            Tools.SetStyle("Body Text enumeration Line1");
        }

        private void level_three_uo_Click(object sender, RibbonControlEventArgs e) {
            Tools.SetStyle("Body Text enumeration Line3");
        }

        private void level_four_uo_Click(object sender, RibbonControlEventArgs e) {
            Tools.SetStyle("Body Text enumeration Point3");
        }

        private void showSpellingErrors_Click_1(object sender, RibbonControlEventArgs e) {
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            doc.ShowSpellingErrors = this.showSpellingErrors.Checked;
        }

        private void insertCrossReference_Click(object sender, RibbonControlEventArgs e) {
            app.Dialogs[Word.WdWordDialog.wdDialogInsertCrossReference].Show();
        }

        private void openParagraphFormatter_Click(object sender, RibbonControlEventArgs e) {
            app.Dialogs[Word.WdWordDialog.wdDialogFormatParagraph].Show();
        }
    }
}
