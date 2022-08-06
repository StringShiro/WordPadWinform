namespace WordPad
{
    partial class WordPad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip_top = new System.Windows.Forms.MenuStrip();
            this.TSMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItem_Format = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItem_Font = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItem_Align = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItem_Color = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItem_Bold = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItem_Italic = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItem_Underline = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItem_Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.symbolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItem_FindAndReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Format = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Insert = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_LeftAlign = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_CenterAlign = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_RightAlign = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Color = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Bold = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Italic = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Underline = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDown_SelectFont = new System.Windows.Forms.ToolStripButton();
            this.Richtxtbox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Numeric_ChangeFontSize = new System.Windows.Forms.NumericUpDown();
            this.TSMenuItem_Find = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_Find = new System.Windows.Forms.TextBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.TSMenuItem_Replace = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_replace = new System.Windows.Forms.Button();
            this.menuStrip_top.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_ChangeFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip_top
            // 
            this.menuStrip_top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenuItem_File,
            this.TSMenuItem_Format,
            this.TSMenuItem_Insert});
            this.menuStrip_top.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_top.Name = "menuStrip_top";
            this.menuStrip_top.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip_top.TabIndex = 0;
            this.menuStrip_top.Text = "menuStrip1";
            // 
            // TSMenuItem_File
            // 
            this.TSMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenuItem_Open,
            this.TSMenuItem_Save,
            this.TSMenuItem_Exit});
            this.TSMenuItem_File.Name = "TSMenuItem_File";
            this.TSMenuItem_File.Size = new System.Drawing.Size(37, 20);
            this.TSMenuItem_File.Text = "File";
            // 
            // TSMenuItem_Open
            // 
            this.TSMenuItem_Open.Name = "TSMenuItem_Open";
            this.TSMenuItem_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.TSMenuItem_Open.Size = new System.Drawing.Size(146, 22);
            this.TSMenuItem_Open.Text = "Open";
            this.TSMenuItem_Open.Click += new System.EventHandler(this.TSMenuItem_Open_Click);
            // 
            // TSMenuItem_Save
            // 
            this.TSMenuItem_Save.Image = global::WordPad.Properties.Resources.save;
            this.TSMenuItem_Save.Name = "TSMenuItem_Save";
            this.TSMenuItem_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.TSMenuItem_Save.Size = new System.Drawing.Size(146, 22);
            this.TSMenuItem_Save.Text = "Save";
            this.TSMenuItem_Save.Click += new System.EventHandler(this.TSMenuItem_Save_Click);
            // 
            // TSMenuItem_Exit
            // 
            this.TSMenuItem_Exit.Name = "TSMenuItem_Exit";
            this.TSMenuItem_Exit.Size = new System.Drawing.Size(146, 22);
            this.TSMenuItem_Exit.Text = "Exit";
            // 
            // TSMenuItem_Format
            // 
            this.TSMenuItem_Format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenuItem_Font,
            this.TSMenuItem_Align,
            this.TSMenuItem_Color,
            this.TSMenuItem_Bold,
            this.TSMenuItem_Italic,
            this.TSMenuItem_Underline,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.TSMenuItem_Format.Name = "TSMenuItem_Format";
            this.TSMenuItem_Format.Size = new System.Drawing.Size(57, 20);
            this.TSMenuItem_Format.Text = "Format";
            // 
            // TSMenuItem_Font
            // 
            this.TSMenuItem_Font.Image = global::WordPad.Properties.Resources.font_icon_icon;
            this.TSMenuItem_Font.Name = "TSMenuItem_Font";
            this.TSMenuItem_Font.Size = new System.Drawing.Size(180, 22);
            this.TSMenuItem_Font.Text = "Font";
            this.TSMenuItem_Font.Click += new System.EventHandler(this.TSMenuItem_Font_Click);
            // 
            // TSMenuItem_Align
            // 
            this.TSMenuItem_Align.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rightToolStripMenuItem,
            this.centerToolStripMenuItem,
            this.leftToolStripMenuItem});
            this.TSMenuItem_Align.Image = global::WordPad.Properties.Resources.center_alignment1;
            this.TSMenuItem_Align.Name = "TSMenuItem_Align";
            this.TSMenuItem_Align.Size = new System.Drawing.Size(180, 22);
            this.TSMenuItem_Align.Text = "Align";
            // 
            // rightToolStripMenuItem
            // 
            this.rightToolStripMenuItem.Image = global::WordPad.Properties.Resources.right_alignment;
            this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            this.rightToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rightToolStripMenuItem.Text = "Right";
            // 
            // centerToolStripMenuItem
            // 
            this.centerToolStripMenuItem.Image = global::WordPad.Properties.Resources.center_alignment;
            this.centerToolStripMenuItem.Name = "centerToolStripMenuItem";
            this.centerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.centerToolStripMenuItem.Text = "Center";
            // 
            // leftToolStripMenuItem
            // 
            this.leftToolStripMenuItem.Image = global::WordPad.Properties.Resources.left_alignment;
            this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            this.leftToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.leftToolStripMenuItem.Text = "Left";
            // 
            // TSMenuItem_Color
            // 
            this.TSMenuItem_Color.Image = global::WordPad.Properties.Resources.font_color;
            this.TSMenuItem_Color.Name = "TSMenuItem_Color";
            this.TSMenuItem_Color.Size = new System.Drawing.Size(180, 22);
            this.TSMenuItem_Color.Text = "Color";
            this.TSMenuItem_Color.Click += new System.EventHandler(this.TSMenuItem_Color_Click);
            // 
            // TSMenuItem_Bold
            // 
            this.TSMenuItem_Bold.Image = global::WordPad.Properties.Resources.edit_bold_icon_icon;
            this.TSMenuItem_Bold.Name = "TSMenuItem_Bold";
            this.TSMenuItem_Bold.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.TSMenuItem_Bold.Size = new System.Drawing.Size(180, 22);
            this.TSMenuItem_Bold.Text = "Bold";
            this.TSMenuItem_Bold.Click += new System.EventHandler(this.TSMenuItem_Bold_Click);
            // 
            // TSMenuItem_Italic
            // 
            this.TSMenuItem_Italic.Image = global::WordPad.Properties.Resources.italic;
            this.TSMenuItem_Italic.Name = "TSMenuItem_Italic";
            this.TSMenuItem_Italic.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.TSMenuItem_Italic.Size = new System.Drawing.Size(180, 22);
            this.TSMenuItem_Italic.Text = "Italic";
            this.TSMenuItem_Italic.Click += new System.EventHandler(this.TSMenuItem_Italic_Click);
            // 
            // TSMenuItem_Underline
            // 
            this.TSMenuItem_Underline.Image = global::WordPad.Properties.Resources.underline;
            this.TSMenuItem_Underline.Name = "TSMenuItem_Underline";
            this.TSMenuItem_Underline.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.TSMenuItem_Underline.Size = new System.Drawing.Size(180, 22);
            this.TSMenuItem_Underline.Text = "Underline";
            this.TSMenuItem_Underline.Click += new System.EventHandler(this.TSMenuItem_Underline_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // TSMenuItem_Insert
            // 
            this.TSMenuItem_Insert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.symbolsToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.TSMenuItem_FindAndReplace});
            this.TSMenuItem_Insert.Name = "TSMenuItem_Insert";
            this.TSMenuItem_Insert.Size = new System.Drawing.Size(48, 20);
            this.TSMenuItem_Insert.Text = "Insert";
            // 
            // symbolsToolStripMenuItem
            // 
            this.symbolsToolStripMenuItem.Image = global::WordPad.Properties.Resources.symbol;
            this.symbolsToolStripMenuItem.Name = "symbolsToolStripMenuItem";
            this.symbolsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.symbolsToolStripMenuItem.Text = "Symbols";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Image = global::WordPad.Properties.Resources.image;
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // TSMenuItem_FindAndReplace
            // 
            this.TSMenuItem_FindAndReplace.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenuItem_Find,
            this.TSMenuItem_Replace});
            this.TSMenuItem_FindAndReplace.Name = "TSMenuItem_FindAndReplace";
            this.TSMenuItem_FindAndReplace.Size = new System.Drawing.Size(180, 22);
            this.TSMenuItem_FindAndReplace.Text = "Find and Replace";
            this.TSMenuItem_FindAndReplace.Click += new System.EventHandler(this.TSMenuItem_FindAndReplace_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_Save,
            this.toolStrip_Format,
            this.toolStrip_Insert,
            this.toolStrip_LeftAlign,
            this.toolStrip_CenterAlign,
            this.toolStrip_RightAlign,
            this.toolStrip_Color,
            this.toolStrip_Bold,
            this.toolStrip_Italic,
            this.toolStrip_Underline,
            this.toolStripDropDown_SelectFont});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStrip_Save
            // 
            this.toolStrip_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Save.Image = global::WordPad.Properties.Resources.save;
            this.toolStrip_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Save.Name = "toolStrip_Save";
            this.toolStrip_Save.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Save.Text = "Save";
            // 
            // toolStrip_Format
            // 
            this.toolStrip_Format.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Format.Image = global::WordPad.Properties.Resources.Format__Paragraph_icon_icon;
            this.toolStrip_Format.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Format.Name = "toolStrip_Format";
            this.toolStrip_Format.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Format.Text = "Format";
            // 
            // toolStrip_Insert
            // 
            this.toolStrip_Insert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Insert.Image = global::WordPad.Properties.Resources.receipt_import_icon_icon;
            this.toolStrip_Insert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Insert.Name = "toolStrip_Insert";
            this.toolStrip_Insert.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Insert.Text = "Insert";
            // 
            // toolStrip_LeftAlign
            // 
            this.toolStrip_LeftAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_LeftAlign.Image = global::WordPad.Properties.Resources.left_alignment;
            this.toolStrip_LeftAlign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_LeftAlign.Name = "toolStrip_LeftAlign";
            this.toolStrip_LeftAlign.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_LeftAlign.Text = "Left";
            // 
            // toolStrip_CenterAlign
            // 
            this.toolStrip_CenterAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_CenterAlign.Image = global::WordPad.Properties.Resources.center_alignment;
            this.toolStrip_CenterAlign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_CenterAlign.Name = "toolStrip_CenterAlign";
            this.toolStrip_CenterAlign.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_CenterAlign.Text = "Center";
            // 
            // toolStrip_RightAlign
            // 
            this.toolStrip_RightAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_RightAlign.Image = global::WordPad.Properties.Resources.right_alignment;
            this.toolStrip_RightAlign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_RightAlign.Name = "toolStrip_RightAlign";
            this.toolStrip_RightAlign.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_RightAlign.Text = "Right";
            // 
            // toolStrip_Color
            // 
            this.toolStrip_Color.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Color.Image = global::WordPad.Properties.Resources.font_color;
            this.toolStrip_Color.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Color.Name = "toolStrip_Color";
            this.toolStrip_Color.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Color.Text = "Font Color";
            this.toolStrip_Color.Click += new System.EventHandler(this.toolStrip_Color_Click);
            // 
            // toolStrip_Bold
            // 
            this.toolStrip_Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Bold.Image = global::WordPad.Properties.Resources.edit_bold_icon_icon;
            this.toolStrip_Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Bold.Name = "toolStrip_Bold";
            this.toolStrip_Bold.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Bold.Text = "Bold";
            this.toolStrip_Bold.Click += new System.EventHandler(this.toolStrip_Bold_Click);
            // 
            // toolStrip_Italic
            // 
            this.toolStrip_Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Italic.Image = global::WordPad.Properties.Resources.italic1;
            this.toolStrip_Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Italic.Name = "toolStrip_Italic";
            this.toolStrip_Italic.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Italic.Text = "Italic";
            this.toolStrip_Italic.Click += new System.EventHandler(this.toolStrip_Italic_Click);
            // 
            // toolStrip_Underline
            // 
            this.toolStrip_Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Underline.Image = global::WordPad.Properties.Resources.underline1;
            this.toolStrip_Underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Underline.Name = "toolStrip_Underline";
            this.toolStrip_Underline.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Underline.Text = "Underline";
            this.toolStrip_Underline.Click += new System.EventHandler(this.toolStrip_Underline_Click);
            // 
            // toolStripDropDown_SelectFont
            // 
            this.toolStripDropDown_SelectFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDown_SelectFont.Image = global::WordPad.Properties.Resources.font_icon_icon;
            this.toolStripDropDown_SelectFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDown_SelectFont.Name = "toolStripDropDown_SelectFont";
            this.toolStripDropDown_SelectFont.Size = new System.Drawing.Size(23, 22);
            this.toolStripDropDown_SelectFont.Text = "Font";
            this.toolStripDropDown_SelectFont.Click += new System.EventHandler(this.toolStripDropDown_SelectFont_Click);
            // 
            // Richtxtbox
            // 
            this.Richtxtbox.ContextMenuStrip = this.contextMenuStrip1;
            this.Richtxtbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Richtxtbox.Location = new System.Drawing.Point(0, 49);
            this.Richtxtbox.Name = "Richtxtbox";
            this.Richtxtbox.Size = new System.Drawing.Size(1264, 632);
            this.Richtxtbox.TabIndex = 2;
            this.Richtxtbox.Text = "";
            this.Richtxtbox.TextChanged += new System.EventHandler(this.Richtxtbox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem1,
            this.cutToolStripMenuItem1,
            this.pasteToolStripMenuItem1,
            this.selectAllToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 92);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.cutToolStripMenuItem1.Text = "Cut";
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.pasteToolStripMenuItem1.Text = "Paste";
            // 
            // selectAllToolStripMenuItem1
            // 
            this.selectAllToolStripMenuItem1.Name = "selectAllToolStripMenuItem1";
            this.selectAllToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.selectAllToolStripMenuItem1.Text = "Select All";
            // 
            // Numeric_ChangeFontSize
            // 
            this.Numeric_ChangeFontSize.Location = new System.Drawing.Point(264, 26);
            this.Numeric_ChangeFontSize.Name = "Numeric_ChangeFontSize";
            this.Numeric_ChangeFontSize.Size = new System.Drawing.Size(45, 20);
            this.Numeric_ChangeFontSize.TabIndex = 3;
            this.Numeric_ChangeFontSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Numeric_ChangeFontSize.ValueChanged += new System.EventHandler(this.Numeric_ChangeFontSize_ValueChanged);
            // 
            // TSMenuItem_Find
            // 
            this.TSMenuItem_Find.Name = "TSMenuItem_Find";
            this.TSMenuItem_Find.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.TSMenuItem_Find.Size = new System.Drawing.Size(180, 22);
            this.TSMenuItem_Find.Text = "Find";
            this.TSMenuItem_Find.Click += new System.EventHandler(this.TSMenuItem_Find_Click);
            // 
            // txt_Find
            // 
            this.txt_Find.Location = new System.Drawing.Point(315, 26);
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(134, 20);
            this.txt_Find.TabIndex = 4;
            this.txt_Find.TextChanged += new System.EventHandler(this.txt_Find_TextChanged);
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(452, 25);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(75, 23);
            this.btn_Find.TabIndex = 5;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // TSMenuItem_Replace
            // 
            this.TSMenuItem_Replace.Name = "TSMenuItem_Replace";
            this.TSMenuItem_Replace.Size = new System.Drawing.Size(180, 22);
            this.TSMenuItem_Replace.Text = "Replace";
            this.TSMenuItem_Replace.Click += new System.EventHandler(this.TSMenuItem_Replace_Click);
            // 
            // btn_replace
            // 
            this.btn_replace.Location = new System.Drawing.Point(529, 25);
            this.btn_replace.Name = "btn_replace";
            this.btn_replace.Size = new System.Drawing.Size(75, 23);
            this.btn_replace.TabIndex = 6;
            this.btn_replace.Text = "Replace";
            this.btn_replace.UseVisualStyleBackColor = true;
            // 
            // WordPad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_replace);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.txt_Find);
            this.Controls.Add(this.Numeric_ChangeFontSize);
            this.Controls.Add(this.Richtxtbox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip_top);
            this.MainMenuStrip = this.menuStrip_top;
            this.Name = "WordPad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordPad";
            this.Load += new System.EventHandler(this.WordPad_Load);
            this.menuStrip_top.ResumeLayout(false);
            this.menuStrip_top.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_ChangeFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_top;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItem_Save;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItem_Exit;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItem_Format;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItem_Font;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItem_Align;
        private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItem_Color;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItem_Insert;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItem_Open;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStrip_Save;
        private System.Windows.Forms.ToolStripButton toolStrip_Format;
        private System.Windows.Forms.ToolStripButton toolStrip_Insert;
        private System.Windows.Forms.ToolStripButton toolStrip_LeftAlign;
        private System.Windows.Forms.ToolStripButton toolStrip_CenterAlign;
        private System.Windows.Forms.ToolStripButton toolStrip_RightAlign;
        private System.Windows.Forms.ToolStripButton toolStrip_Color;
        private System.Windows.Forms.RichTextBox Richtxtbox;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItem_Bold;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItem_Italic;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItem_Underline;
        private System.Windows.Forms.ToolStripButton toolStrip_Bold;
        private System.Windows.Forms.ToolStripButton toolStrip_Italic;
        private System.Windows.Forms.ToolStripButton toolStrip_Underline;
        private System.Windows.Forms.NumericUpDown Numeric_ChangeFontSize;
        private System.Windows.Forms.ToolStripButton toolStripDropDown_SelectFont;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem symbolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItem_FindAndReplace;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItem_Find;
        private System.Windows.Forms.TextBox txt_Find;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItem_Replace;
        private System.Windows.Forms.Button btn_replace;
    }
}

