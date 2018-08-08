﻿namespace DocumentControlToolbar
{
    partial class DocumentControlRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public DocumentControlRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentControlRibbon));
            this.DocControl = this.Factory.CreateRibbonTab();
            this.Document = this.Factory.CreateRibbonGroup();
            this.separator2 = this.Factory.CreateRibbonSeparator();
            this.textToolsGroup = this.Factory.CreateRibbonGroup();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.box1 = this.Factory.CreateRibbonBox();
            this.box2 = this.Factory.CreateRibbonBox();
            this.acronymTableGroup = this.Factory.CreateRibbonGroup();
            this.crossRefsGroup = this.Factory.CreateRibbonGroup();
            this.docPropUpdater = this.Factory.CreateRibbonButton();
            this.download = this.Factory.CreateRibbonButton();
            this.acceptAllChanges = this.Factory.CreateRibbonButton();
            this.showMarkup = this.Factory.CreateRibbonToggleButton();
            this.insertSectionBreak = this.Factory.CreateRibbonButton();
            this.headingsDropdown = this.Factory.CreateRibbonGallery();
            this.headingOne = this.Factory.CreateRibbonButton();
            this.headingTwo = this.Factory.CreateRibbonButton();
            this.headingThree = this.Factory.CreateRibbonButton();
            this.headingFour = this.Factory.CreateRibbonButton();
            this.headingFive = this.Factory.CreateRibbonButton();
            this.applyBodyStyle = this.Factory.CreateRibbonButton();
            this.applyFigureStyle = this.Factory.CreateRibbonButton();
            this.applyMarkingStyle = this.Factory.CreateRibbonButton();
            this.keepWithNext = this.Factory.CreateRibbonButton();
            this.pageBreakBefore = this.Factory.CreateRibbonButton();
            this.defaultUL = this.Factory.CreateRibbonButton();
            this.unorderedDropdown = this.Factory.CreateRibbonGallery();
            this.level_one_uo = this.Factory.CreateRibbonButton();
            this.level_two_uo = this.Factory.CreateRibbonButton();
            this.level_three_uo = this.Factory.CreateRibbonButton();
            this.level_four_uo = this.Factory.CreateRibbonButton();
            this.defaultOL = this.Factory.CreateRibbonButton();
            this.orderedListGallery = this.Factory.CreateRibbonGallery();
            this.level_one_ol = this.Factory.CreateRibbonButton();
            this.level_two_ol = this.Factory.CreateRibbonButton();
            this.formatTable = this.Factory.CreateRibbonButton();
            this.runAcronymTool = this.Factory.CreateRibbonButton();
            this.updateWordlist = this.Factory.CreateRibbonButton();
            this.updateDudsList = this.Factory.CreateRibbonButton();
            this.figureRefButton = this.Factory.CreateRibbonButton();
            this.tableRefButton = this.Factory.CreateRibbonButton();
            this.updateAllFields = this.Factory.CreateRibbonButton();
            this.DocControl.SuspendLayout();
            this.Document.SuspendLayout();
            this.textToolsGroup.SuspendLayout();
            this.group2.SuspendLayout();
            this.box1.SuspendLayout();
            this.box2.SuspendLayout();
            this.acronymTableGroup.SuspendLayout();
            this.crossRefsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // DocControl
            // 
            this.DocControl.Groups.Add(this.Document);
            this.DocControl.Groups.Add(this.textToolsGroup);
            this.DocControl.Groups.Add(this.group2);
            this.DocControl.Groups.Add(this.acronymTableGroup);
            this.DocControl.Groups.Add(this.crossRefsGroup);
            this.DocControl.Label = "Doc Control";
            this.DocControl.Name = "DocControl";
            // 
            // Document
            // 
            this.Document.Items.Add(this.docPropUpdater);
            this.Document.Items.Add(this.download);
            this.Document.Items.Add(this.acceptAllChanges);
            this.Document.Items.Add(this.separator2);
            this.Document.Items.Add(this.showMarkup);
            this.Document.Label = "Document";
            this.Document.Name = "Document";
            // 
            // separator2
            // 
            this.separator2.Name = "separator2";
            // 
            // textToolsGroup
            // 
            this.textToolsGroup.Items.Add(this.insertSectionBreak);
            this.textToolsGroup.Items.Add(this.separator1);
            this.textToolsGroup.Items.Add(this.headingsDropdown);
            this.textToolsGroup.Items.Add(this.applyBodyStyle);
            this.textToolsGroup.Items.Add(this.applyFigureStyle);
            this.textToolsGroup.Items.Add(this.applyMarkingStyle);
            this.textToolsGroup.Items.Add(this.keepWithNext);
            this.textToolsGroup.Items.Add(this.pageBreakBefore);
            this.textToolsGroup.Label = "Style";
            this.textToolsGroup.Name = "textToolsGroup";
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // group2
            // 
            this.group2.Items.Add(this.box1);
            this.group2.Items.Add(this.box2);
            this.group2.Label = "List";
            this.group2.Name = "group2";
            // 
            // box1
            // 
            this.box1.Items.Add(this.defaultUL);
            this.box1.Items.Add(this.unorderedDropdown);
            this.box1.Name = "box1";
            // 
            // box2
            // 
            this.box2.Items.Add(this.defaultOL);
            this.box2.Items.Add(this.orderedListGallery);
            this.box2.Name = "box2";
            // 
            // acronymTableGroup
            // 
            this.acronymTableGroup.Items.Add(this.formatTable);
            this.acronymTableGroup.Items.Add(this.runAcronymTool);
            this.acronymTableGroup.Items.Add(this.updateWordlist);
            this.acronymTableGroup.Items.Add(this.updateDudsList);
            this.acronymTableGroup.Label = "Table";
            this.acronymTableGroup.Name = "acronymTableGroup";
            // 
            // crossRefsGroup
            // 
            this.crossRefsGroup.Items.Add(this.figureRefButton);
            this.crossRefsGroup.Items.Add(this.tableRefButton);
            this.crossRefsGroup.Items.Add(this.updateAllFields);
            this.crossRefsGroup.Label = "Cross-references";
            this.crossRefsGroup.Name = "crossRefsGroup";
            // 
            // docPropUpdater
            // 
            this.docPropUpdater.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.docPropUpdater.Image = global::DocumentControlToolbar.Properties.Resources.properties_icon_raw;
            this.docPropUpdater.Label = "Document Properties Editor";
            this.docPropUpdater.Name = "docPropUpdater";
            this.docPropUpdater.ScreenTip = "Opens a dialog by which users can easily update a document\'s metadata.";
            this.docPropUpdater.ShowImage = true;
            this.docPropUpdater.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.docPropUpdater_Click);
            // 
            // download
            // 
            this.download.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.download.Image = global::DocumentControlToolbar.Properties.Resources.import_styles;
            this.download.Label = "Import Styles";
            this.download.Name = "download";
            this.download.ShowImage = true;
            this.download.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.headings_Click);
            // 
            // acceptAllChanges
            // 
            this.acceptAllChanges.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.acceptAllChanges.Image = global::DocumentControlToolbar.Properties.Resources.accept_all_changes;
            this.acceptAllChanges.Label = "Accept All Changes";
            this.acceptAllChanges.Name = "acceptAllChanges";
            this.acceptAllChanges.ShowImage = true;
            this.acceptAllChanges.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.acceptAllChanges_Click);
            // 
            // showMarkup
            // 
            this.showMarkup.Image = global::DocumentControlToolbar.Properties.Resources.show_markup_small;
            this.showMarkup.Label = "Show";
            this.showMarkup.Name = "showMarkup";
            this.showMarkup.ShowImage = true;
            this.showMarkup.ShowLabel = false;
            this.showMarkup.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.showMarkup_Click);
            // 
            // insertSectionBreak
            // 
            this.insertSectionBreak.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.insertSectionBreak.Image = global::DocumentControlToolbar.Properties.Resources.section_break_icon;
            this.insertSectionBreak.Label = "Insert Section Break";
            this.insertSectionBreak.Name = "insertSectionBreak";
            this.insertSectionBreak.ShowImage = true;
            this.insertSectionBreak.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.insertSectionBreak_Click);
            // 
            // headingsDropdown
            // 
            this.headingsDropdown.Buttons.Add(this.headingOne);
            this.headingsDropdown.Buttons.Add(this.headingTwo);
            this.headingsDropdown.Buttons.Add(this.headingThree);
            this.headingsDropdown.Buttons.Add(this.headingFour);
            this.headingsDropdown.Buttons.Add(this.headingFive);
            this.headingsDropdown.ColumnCount = 1;
            this.headingsDropdown.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.headingsDropdown.Image = global::DocumentControlToolbar.Properties.Resources.headings_icon;
            this.headingsDropdown.Label = "Headings";
            this.headingsDropdown.Name = "headingsDropdown";
            this.headingsDropdown.ShowImage = true;
            // 
            // headingOne
            // 
            this.headingOne.Label = "Level 1";
            this.headingOne.Name = "headingOne";
            this.headingOne.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.headingOne_Click);
            // 
            // headingTwo
            // 
            this.headingTwo.Label = "Level 2";
            this.headingTwo.Name = "headingTwo";
            this.headingTwo.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.headingTwo_Click);
            // 
            // headingThree
            // 
            this.headingThree.Label = "Level 3";
            this.headingThree.Name = "headingThree";
            this.headingThree.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.headingThree_Click);
            // 
            // headingFour
            // 
            this.headingFour.Label = "Level 4";
            this.headingFour.Name = "headingFour";
            this.headingFour.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.headingFour_Click);
            // 
            // headingFive
            // 
            this.headingFive.Label = "Level 5";
            this.headingFive.Name = "headingFive";
            this.headingFive.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.headingFive_Click);
            // 
            // applyBodyStyle
            // 
            this.applyBodyStyle.Image = global::DocumentControlToolbar.Properties.Resources.apply_style_small_icon;
            this.applyBodyStyle.Label = "Body";
            this.applyBodyStyle.Name = "applyBodyStyle";
            this.applyBodyStyle.ShowImage = true;
            this.applyBodyStyle.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.applyBodyStyle_Click);
            // 
            // applyFigureStyle
            // 
            this.applyFigureStyle.Image = global::DocumentControlToolbar.Properties.Resources.figure_style_small;
            this.applyFigureStyle.Label = "Figure";
            this.applyFigureStyle.Name = "applyFigureStyle";
            this.applyFigureStyle.ShowImage = true;
            this.applyFigureStyle.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.applyFigureStyle_Click);
            // 
            // applyMarkingStyle
            // 
            this.applyMarkingStyle.Image = global::DocumentControlToolbar.Properties.Resources.marking_style_small;
            this.applyMarkingStyle.Label = "Marking";
            this.applyMarkingStyle.Name = "applyMarkingStyle";
            this.applyMarkingStyle.ShowImage = true;
            this.applyMarkingStyle.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.applyMarkingStyle_Click);
            // 
            // keepWithNext
            // 
            this.keepWithNext.Image = global::DocumentControlToolbar.Properties.Resources.keep_with_next_small;
            this.keepWithNext.Label = "Keep With Next ";
            this.keepWithNext.Name = "keepWithNext";
            this.keepWithNext.ShowImage = true;
            this.keepWithNext.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.keepWithNext_Click);
            // 
            // pageBreakBefore
            // 
            this.pageBreakBefore.Image = global::DocumentControlToolbar.Properties.Resources.page_break_before_small_icon;
            this.pageBreakBefore.Label = "Page Break Before ";
            this.pageBreakBefore.Name = "pageBreakBefore";
            this.pageBreakBefore.ShowImage = true;
            this.pageBreakBefore.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.pageBreakBefore_Click);
            // 
            // defaultUL
            // 
            this.defaultUL.Image = global::DocumentControlToolbar.Properties.Resources.apply_list_small_icon;
            this.defaultUL.Label = "Apply Default UL";
            this.defaultUL.Name = "defaultUL";
            this.defaultUL.ShowImage = true;
            this.defaultUL.ShowLabel = false;
            this.defaultUL.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.defaultUL_Click);
            // 
            // unorderedDropdown
            // 
            this.unorderedDropdown.Buttons.Add(this.level_one_uo);
            this.unorderedDropdown.Buttons.Add(this.level_two_uo);
            this.unorderedDropdown.Buttons.Add(this.level_three_uo);
            this.unorderedDropdown.Buttons.Add(this.level_four_uo);
            this.unorderedDropdown.Label = " Apply UL";
            this.unorderedDropdown.Name = "unorderedDropdown";
            // 
            // level_one_uo
            // 
            this.level_one_uo.Image = global::DocumentControlToolbar.Properties.Resources.level_one_ul;
            this.level_one_uo.Label = "Level 1";
            this.level_one_uo.Name = "level_one_uo";
            this.level_one_uo.ShowImage = true;
            this.level_one_uo.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.level_one_uo_Click);
            // 
            // level_two_uo
            // 
            this.level_two_uo.Image = global::DocumentControlToolbar.Properties.Resources.level_two_ul;
            this.level_two_uo.Label = "Level 2";
            this.level_two_uo.Name = "level_two_uo";
            this.level_two_uo.ShowImage = true;
            this.level_two_uo.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.level_two_uo_Click);
            // 
            // level_three_uo
            // 
            this.level_three_uo.Image = global::DocumentControlToolbar.Properties.Resources.level_three_ul;
            this.level_three_uo.Label = "Level 3";
            this.level_three_uo.Name = "level_three_uo";
            this.level_three_uo.ShowImage = true;
            this.level_three_uo.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.level_three_uo_Click);
            // 
            // level_four_uo
            // 
            this.level_four_uo.Image = global::DocumentControlToolbar.Properties.Resources.level_four_ul;
            this.level_four_uo.Label = "Level 4";
            this.level_four_uo.Name = "level_four_uo";
            this.level_four_uo.ShowImage = true;
            this.level_four_uo.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.level_four_uo_Click);
            // 
            // defaultOL
            // 
            this.defaultOL.Image = global::DocumentControlToolbar.Properties.Resources.apply_o_list_small_icon;
            this.defaultOL.Label = "Apply Default OL";
            this.defaultOL.Name = "defaultOL";
            this.defaultOL.ShowImage = true;
            this.defaultOL.ShowLabel = false;
            this.defaultOL.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.defaultOL_Click);
            // 
            // orderedListGallery
            // 
            this.orderedListGallery.Buttons.Add(this.level_one_ol);
            this.orderedListGallery.Buttons.Add(this.level_two_ol);
            this.orderedListGallery.Label = " Apply OL";
            this.orderedListGallery.Name = "orderedListGallery";
            // 
            // level_one_ol
            // 
            this.level_one_ol.Image = global::DocumentControlToolbar.Properties.Resources.level_one_ol;
            this.level_one_ol.Label = "Level 1";
            this.level_one_ol.Name = "level_one_ol";
            this.level_one_ol.ShowImage = true;
            this.level_one_ol.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.level_one_ol_Click);
            // 
            // level_two_ol
            // 
            this.level_two_ol.Image = global::DocumentControlToolbar.Properties.Resources.level_two_ol;
            this.level_two_ol.Label = "Level 2";
            this.level_two_ol.Name = "level_two_ol";
            this.level_two_ol.ShowImage = true;
            this.level_two_ol.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.level_two_ol_Click);
            // 
            // formatTable
            // 
            this.formatTable.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.formatTable.Image = global::DocumentControlToolbar.Properties.Resources.table_icon;
            this.formatTable.Label = "Format Table";
            this.formatTable.Name = "formatTable";
            this.formatTable.ShowImage = true;
            this.formatTable.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.formatTable_Click);
            // 
            // runAcronymTool
            // 
            this.runAcronymTool.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.runAcronymTool.Image = ((System.Drawing.Image)(resources.GetObject("runAcronymTool.Image")));
            this.runAcronymTool.Label = "Acronym Table Updater";
            this.runAcronymTool.Name = "runAcronymTool";
            this.runAcronymTool.ShowImage = true;
            this.runAcronymTool.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.runAcronymTool_Click);
            // 
            // updateWordlist
            // 
            this.updateWordlist.Image = global::DocumentControlToolbar.Properties.Resources.update_small_icon;
            this.updateWordlist.Label = " Update Wordlist ";
            this.updateWordlist.Name = "updateWordlist";
            this.updateWordlist.ShowImage = true;
            this.updateWordlist.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.updateWordlist_Click);
            // 
            // updateDudsList
            // 
            this.updateDudsList.Image = global::DocumentControlToolbar.Properties.Resources.update_small_icon;
            this.updateDudsList.Label = " Update Duds List ";
            this.updateDudsList.Name = "updateDudsList";
            this.updateDudsList.ShowImage = true;
            this.updateDudsList.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.updateDudsList_Click);
            // 
            // figureRefButton
            // 
            this.figureRefButton.Image = global::DocumentControlToolbar.Properties.Resources.insert_figure_ref_small_icon;
            this.figureRefButton.Label = " Insert Figure Ref ";
            this.figureRefButton.Name = "figureRefButton";
            this.figureRefButton.ShowImage = true;
            this.figureRefButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.figureRefButton_Click);
            // 
            // tableRefButton
            // 
            this.tableRefButton.Image = global::DocumentControlToolbar.Properties.Resources.insert_table_ref_small_icon;
            this.tableRefButton.Label = " Insert Table Ref ";
            this.tableRefButton.Name = "tableRefButton";
            this.tableRefButton.ShowImage = true;
            this.tableRefButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.tableRefButton_Click);
            // 
            // updateAllFields
            // 
            this.updateAllFields.Image = global::DocumentControlToolbar.Properties.Resources.update_small_icon;
            this.updateAllFields.Label = "Update All Fields";
            this.updateAllFields.Name = "updateAllFields";
            this.updateAllFields.ShowImage = true;
            this.updateAllFields.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.updateAllFields_Click);
            // 
            // DocumentControlRibbon
            // 
            this.Name = "DocumentControlRibbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.DocControl);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.DocControl.ResumeLayout(false);
            this.DocControl.PerformLayout();
            this.Document.ResumeLayout(false);
            this.Document.PerformLayout();
            this.textToolsGroup.ResumeLayout(false);
            this.textToolsGroup.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.box1.ResumeLayout(false);
            this.box1.PerformLayout();
            this.box2.ResumeLayout(false);
            this.box2.PerformLayout();
            this.acronymTableGroup.ResumeLayout(false);
            this.acronymTableGroup.PerformLayout();
            this.crossRefsGroup.ResumeLayout(false);
            this.crossRefsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal Microsoft.Office.Tools.Ribbon.RibbonTab DocControl;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup textToolsGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton applyBodyStyle;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup crossRefsGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton figureRefButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton tableRefButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton docPropUpdater;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton runAcronymTool;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton updateAllFields;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton defaultUL;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton defaultOL;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup acronymTableGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton updateWordlist;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton updateDudsList;
        internal Microsoft.Office.Tools.Ribbon.RibbonGallery headingsDropdown;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton headingOne;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton headingTwo;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton headingThree;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton headingFour;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton headingFive;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton insertSectionBreak;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton formatTable;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton acceptAllChanges;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton download;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton applyMarkingStyle;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton applyFigureStyle;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton showMarkup;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Document;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton keepWithNext;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton pageBreakBefore;
        internal Microsoft.Office.Tools.Ribbon.RibbonGallery unorderedDropdown;
        private Microsoft.Office.Tools.Ribbon.RibbonButton level_one_uo;
        private Microsoft.Office.Tools.Ribbon.RibbonButton level_two_uo;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box1;
        private Microsoft.Office.Tools.Ribbon.RibbonButton level_three_uo;
        private Microsoft.Office.Tools.Ribbon.RibbonButton level_four_uo;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box2;
        internal Microsoft.Office.Tools.Ribbon.RibbonGallery orderedListGallery;
        private Microsoft.Office.Tools.Ribbon.RibbonButton level_one_ol;
        private Microsoft.Office.Tools.Ribbon.RibbonButton level_two_ol;
    }

    partial class ThisRibbonCollection
    {
        internal DocumentControlRibbon Ribbon1
        {
            get { return this.GetRibbon<DocumentControlRibbon>(); }
        }
    }
}
