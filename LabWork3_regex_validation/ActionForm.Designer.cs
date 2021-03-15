
namespace OOP_SEM3_L2
{
    partial class ActionForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionForm));
            this.NewDiscipline = new System.Windows.Forms.Button();
            this.Alldiscipline = new System.Windows.Forms.Button();
            this.OutNameDis = new System.Windows.Forms.TextBox();
            this.ListDiscipline = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Поиск = new System.Windows.Forms.ToolStripMenuItem();
            this.ByLector = new System.Windows.Forms.ToolStripMenuItem();
            this.FindedLector = new System.Windows.Forms.ToolStripTextBox();
            this.ByCours = new System.Windows.Forms.ToolStripMenuItem();
            this.FindedCours = new System.Windows.Forms.ToolStripTextBox();
            this.BySemestr = new System.Windows.Forms.ToolStripMenuItem();
            this.FindedSem = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ByCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.ByControlType = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutAppMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HideShowTools = new System.Windows.Forms.ToolStripMenuItem();
            this.OutFindInf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Tools = new System.Windows.Forms.Panel();
            this.SortByCoursTool = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FindByLecturerTool = new System.Windows.Forms.TextBox();
            this.AboutApp = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripByCours = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripByCoursTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripBySemestr = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBySemestrTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1.SuspendLayout();
            this.Tools.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewDiscipline
            // 
            this.NewDiscipline.Location = new System.Drawing.Point(199, 434);
            this.NewDiscipline.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewDiscipline.Name = "NewDiscipline";
            this.NewDiscipline.Size = new System.Drawing.Size(353, 29);
            this.NewDiscipline.TabIndex = 0;
            this.NewDiscipline.Text = "Новая дисциплина";
            this.NewDiscipline.UseVisualStyleBackColor = true;
            this.NewDiscipline.Click += new System.EventHandler(this.NewDiscipline_Click);
            // 
            // Alldiscipline
            // 
            this.Alldiscipline.Location = new System.Drawing.Point(18, 101);
            this.Alldiscipline.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Alldiscipline.Name = "Alldiscipline";
            this.Alldiscipline.Size = new System.Drawing.Size(158, 29);
            this.Alldiscipline.TabIndex = 3;
            this.Alldiscipline.Text = "Все дисциплины";
            this.Alldiscipline.UseVisualStyleBackColor = true;
            this.Alldiscipline.Click += new System.EventHandler(this.Alldiscipline_Click);
            // 
            // OutNameDis
            // 
            this.OutNameDis.Location = new System.Drawing.Point(18, 152);
            this.OutNameDis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OutNameDis.Multiline = true;
            this.OutNameDis.Name = "OutNameDis";
            this.OutNameDis.ReadOnly = true;
            this.OutNameDis.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutNameDis.Size = new System.Drawing.Size(352, 274);
            this.OutNameDis.TabIndex = 21;
            // 
            // ListDiscipline
            // 
            this.ListDiscipline.FormattingEnabled = true;
            this.ListDiscipline.Location = new System.Drawing.Point(211, 101);
            this.ListDiscipline.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListDiscipline.Name = "ListDiscipline";
            this.ListDiscipline.Size = new System.Drawing.Size(158, 28);
            this.ListDiscipline.TabIndex = 22;
            this.ListDiscipline.SelectedIndexChanged += new System.EventHandler(this.ListDiscipline_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(915, 33);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Поиск,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.AboutAppMenu,
            this.HideShowTools});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(78, 29);
            this.toolStripMenuItem1.Text = "Меню";
            // 
            // Поиск
            // 
            this.Поиск.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ByLector,
            this.ByCours,
            this.BySemestr});
            this.Поиск.Name = "Поиск";
            this.Поиск.Size = new System.Drawing.Size(240, 34);
            this.Поиск.Text = "Поиск";
            // 
            // ByLector
            // 
            this.ByLector.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FindedLector});
            this.ByLector.Name = "ByLector";
            this.ByLector.Size = new System.Drawing.Size(214, 34);
            this.ByLector.Text = "по лектору";
            // 
            // FindedLector
            // 
            this.FindedLector.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FindedLector.Name = "FindedLector";
            this.FindedLector.Size = new System.Drawing.Size(100, 31);
            this.FindedLector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FindedLector_KeyPress);
            this.FindedLector.DoubleClick += new System.EventHandler(this.FindedLector_DoubleClick);
            // 
            // ByCours
            // 
            this.ByCours.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FindedCours});
            this.ByCours.Name = "ByCours";
            this.ByCours.Size = new System.Drawing.Size(214, 34);
            this.ByCours.Text = "по курсу";
            // 
            // FindedCours
            // 
            this.FindedCours.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FindedCours.Name = "FindedCours";
            this.FindedCours.Size = new System.Drawing.Size(100, 31);
            this.FindedCours.DoubleClick += new System.EventHandler(this.FindedCours_DoubleClick);
            // 
            // BySemestr
            // 
            this.BySemestr.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FindedSem});
            this.BySemestr.Name = "BySemestr";
            this.BySemestr.Size = new System.Drawing.Size(214, 34);
            this.BySemestr.Text = "по семестру";
            // 
            // FindedSem
            // 
            this.FindedSem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FindedSem.Name = "FindedSem";
            this.FindedSem.Size = new System.Drawing.Size(100, 31);
            this.FindedSem.DoubleClick += new System.EventHandler(this.FindedSem_DoubleClick);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ByCourse,
            this.ByControlType});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(240, 34);
            this.toolStripMenuItem3.Text = "Сортировка по";
            // 
            // ByCourse
            // 
            this.ByCourse.Name = "ByCourse";
            this.ByCourse.Size = new System.Drawing.Size(261, 34);
            this.ByCourse.Text = "по курсу";
            this.ByCourse.Click += new System.EventHandler(this.ByCourse_Click);
            // 
            // ByControlType
            // 
            this.ByControlType.Name = "ByControlType";
            this.ByControlType.Size = new System.Drawing.Size(261, 34);
            this.ByControlType.Text = "по виду контроля";
            this.ByControlType.Click += new System.EventHandler(this.ByControlType_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(240, 34);
            this.toolStripMenuItem4.Text = "Сохранить";
            // 
            // AboutAppMenu
            // 
            this.AboutAppMenu.Name = "AboutAppMenu";
            this.AboutAppMenu.Size = new System.Drawing.Size(240, 34);
            this.AboutAppMenu.Text = "О программе";
            this.AboutAppMenu.Click += new System.EventHandler(this.AboutAppMenu_Click);
            // 
            // HideShowTools
            // 
            this.HideShowTools.Name = "HideShowTools";
            this.HideShowTools.Size = new System.Drawing.Size(240, 34);
            this.HideShowTools.Text = "инструменты";
            this.HideShowTools.Click += new System.EventHandler(this.HideShowTools_Click);
            // 
            // OutFindInf
            // 
            this.OutFindInf.Location = new System.Drawing.Point(376, 152);
            this.OutFindInf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OutFindInf.Multiline = true;
            this.OutFindInf.Name = "OutFindInf";
            this.OutFindInf.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutFindInf.Size = new System.Drawing.Size(353, 274);
            this.OutFindInf.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Сохранить текущие рез. поиска или сорт.";
            // 
            // SaveAs
            // 
            this.SaveAs.Location = new System.Drawing.Point(376, 115);
            this.SaveAs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(353, 29);
            this.SaveAs.TabIndex = 26;
            this.SaveAs.Text = "Сохранить как";
            this.SaveAs.UseVisualStyleBackColor = true;
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // Tools
            // 
            this.Tools.Controls.Add(this.SortByCoursTool);
            this.Tools.Controls.Add(this.label2);
            this.Tools.Controls.Add(this.FindByLecturerTool);
            this.Tools.Controls.Add(this.AboutApp);
            this.Tools.Controls.Add(this.Save);
            this.Tools.Location = new System.Drawing.Point(18, 434);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(175, 168);
            this.Tools.TabIndex = 27;
            this.Tools.Visible = false;
            // 
            // SortByCoursTool
            // 
            this.SortByCoursTool.Location = new System.Drawing.Point(29, 104);
            this.SortByCoursTool.Name = "SortByCoursTool";
            this.SortByCoursTool.Size = new System.Drawing.Size(140, 29);
            this.SortByCoursTool.TabIndex = 5;
            this.SortByCoursTool.Text = "сорт. курс";
            this.SortByCoursTool.UseVisualStyleBackColor = true;
            this.SortByCoursTool.Click += new System.EventHandler(this.SortByCoursTool_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "инструменты";
            // 
            // FindByLecturerTool
            // 
            this.FindByLecturerTool.Location = new System.Drawing.Point(29, 139);
            this.FindByLecturerTool.Name = "FindByLecturerTool";
            this.FindByLecturerTool.Size = new System.Drawing.Size(140, 26);
            this.FindByLecturerTool.TabIndex = 2;
            this.FindByLecturerTool.Text = "поиск по лектору";
            this.FindByLecturerTool.DoubleClick += new System.EventHandler(this.FindByLecturerTool_DoubleClick);
            // 
            // AboutApp
            // 
            this.AboutApp.Location = new System.Drawing.Point(29, 68);
            this.AboutApp.Name = "AboutApp";
            this.AboutApp.Size = new System.Drawing.Size(140, 30);
            this.AboutApp.TabIndex = 1;
            this.AboutApp.Text = "о программе";
            this.AboutApp.UseVisualStyleBackColor = true;
            this.AboutApp.Click += new System.EventHandler(this.AboutApp_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(29, 32);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(140, 30);
            this.Save.TabIndex = 0;
            this.Save.Text = " сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(915, 33);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripByCours,
            this.toolStripBySemestr});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(45, 28);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripByCours
            // 
            this.toolStripByCours.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripByCoursTextBox});
            this.toolStripByCours.Name = "toolStripByCours";
            this.toolStripByCours.Size = new System.Drawing.Size(270, 34);
            this.toolStripByCours.Text = "по курсу";
            // 
            // toolStripByCoursTextBox
            // 
            this.toolStripByCoursTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripByCoursTextBox.Name = "toolStripByCoursTextBox";
            this.toolStripByCoursTextBox.Size = new System.Drawing.Size(100, 31);
            this.toolStripByCoursTextBox.DoubleClick += new System.EventHandler(this.toolStripByCoursTextBox_DoubleClick_1);
            // 
            // toolStripBySemestr
            // 
            this.toolStripBySemestr.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBySemestrTextBox});
            this.toolStripBySemestr.Name = "toolStripBySemestr";
            this.toolStripBySemestr.Size = new System.Drawing.Size(270, 34);
            this.toolStripBySemestr.Text = "по семестру";
            // 
            // toolStripBySemestrTextBox
            // 
            this.toolStripBySemestrTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripBySemestrTextBox.Name = "toolStripBySemestrTextBox";
            this.toolStripBySemestrTextBox.Size = new System.Drawing.Size(100, 31);
            this.toolStripBySemestrTextBox.DoubleClick += new System.EventHandler(this.toolStripBySemestrTextBox_DoubleClick_1);
            // 
            // ActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 642);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Tools);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutFindInf);
            this.Controls.Add(this.ListDiscipline);
            this.Controls.Add(this.OutNameDis);
            this.Controls.Add(this.Alldiscipline);
            this.Controls.Add(this.NewDiscipline);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ActionForm";
            this.Text = "Действия";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewDiscipline;
        private System.Windows.Forms.Button Alldiscipline;
        private System.Windows.Forms.TextBox OutNameDis;
        private System.Windows.Forms.ComboBox ListDiscipline;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Поиск;
        private System.Windows.Forms.ToolStripMenuItem ByLector;
        private System.Windows.Forms.ToolStripMenuItem ByCours;
        private System.Windows.Forms.ToolStripMenuItem BySemestr;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ByCourse;
        private System.Windows.Forms.ToolStripMenuItem ByControlType;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem AboutAppMenu;
        private System.Windows.Forms.ToolStripTextBox FindedLector;
        private System.Windows.Forms.ToolStripTextBox FindedCours;
        private System.Windows.Forms.ToolStripTextBox FindedSem;
        private System.Windows.Forms.TextBox OutFindInf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveAs;
        private System.Windows.Forms.Panel Tools;
        private System.Windows.Forms.Button AboutApp;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FindByLecturerTool;
        private System.Windows.Forms.ToolStripMenuItem HideShowTools;
        private System.Windows.Forms.Button SortByCoursTool;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripByCours;
        private System.Windows.Forms.ToolStripTextBox toolStripByCoursTextBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripBySemestr;
        private System.Windows.Forms.ToolStripTextBox toolStripBySemestrTextBox;
    }
}

