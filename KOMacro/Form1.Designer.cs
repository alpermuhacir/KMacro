namespace KOMacro
{
    partial class frmKOmacro
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKOmacro));
            this.txtInfo = new System.Windows.Forms.Label();
            this.txtShortCut02 = new System.Windows.Forms.Label();
            this.txtShortCut01 = new System.Windows.Forms.Label();
            this.cmbSecondSpeed07 = new System.Windows.Forms.ComboBox();
            this.cmbSecondSpeed06 = new System.Windows.Forms.ComboBox();
            this.cmbSecondSpeed05 = new System.Windows.Forms.ComboBox();
            this.cmbMiliSpeed04 = new System.Windows.Forms.ComboBox();
            this.cmbMiliSpeed03 = new System.Windows.Forms.ComboBox();
            this.cmbMiliSpeed02 = new System.Windows.Forms.ComboBox();
            this.cmbMiliSpeed01 = new System.Windows.Forms.ComboBox();
            this.chcSkill07Active = new System.Windows.Forms.CheckBox();
            this.txtSecondSkillActive = new System.Windows.Forms.Label();
            this.edtSkill07 = new System.Windows.Forms.TextBox();
            this.txtSpeedSecond = new System.Windows.Forms.Label();
            this.txtSkill07 = new System.Windows.Forms.Label();
            this.txtNumber2 = new System.Windows.Forms.Label();
            this.btnStartBasic = new System.Windows.Forms.Button();
            this.btnStartSkills = new System.Windows.Forms.Button();
            this.chcSkill06Active = new System.Windows.Forms.CheckBox();
            this.chcSkill05Active = new System.Windows.Forms.CheckBox();
            this.edtSkill06 = new System.Windows.Forms.TextBox();
            this.txtSkill06 = new System.Windows.Forms.Label();
            this.chcSkill04Active = new System.Windows.Forms.CheckBox();
            this.edtSkill05 = new System.Windows.Forms.TextBox();
            this.txtSkill05 = new System.Windows.Forms.Label();
            this.chcSkill03Active = new System.Windows.Forms.CheckBox();
            this.edtSkill04 = new System.Windows.Forms.TextBox();
            this.txtSkill04 = new System.Windows.Forms.Label();
            this.edtSkill03 = new System.Windows.Forms.TextBox();
            this.chcSkill02Active = new System.Windows.Forms.CheckBox();
            this.txtSkill03 = new System.Windows.Forms.Label();
            this.edtSkill02 = new System.Windows.Forms.TextBox();
            this.txtSkillActive = new System.Windows.Forms.Label();
            this.txtSkill02 = new System.Windows.Forms.Label();
            this.chcSkill01Active = new System.Windows.Forms.CheckBox();
            this.txtSpeedMiliSecond = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.Label();
            this.edtSkill01 = new System.Windows.Forms.TextBox();
            this.txtSkill01 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(18, 337);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(200, 36);
            this.txtInfo.TabIndex = 87;
            this.txtInfo.Text = "CTRL + Space ile programı her zaman alta alabilir, geri getirebilirsin.";
            this.txtInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtShortCut02
            // 
            this.txtShortCut02.Location = new System.Drawing.Point(128, 304);
            this.txtShortCut02.Name = "txtShortCut02";
            this.txtShortCut02.Size = new System.Drawing.Size(64, 29);
            this.txtShortCut02.TabIndex = 86;
            this.txtShortCut02.Text = "Kısayol: Tab";
            this.txtShortCut02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtShortCut01
            // 
            this.txtShortCut01.Location = new System.Drawing.Point(41, 304);
            this.txtShortCut01.Name = "txtShortCut01";
            this.txtShortCut01.Size = new System.Drawing.Size(75, 29);
            this.txtShortCut01.TabIndex = 85;
            this.txtShortCut01.Text = "Kısayol: Caps-Lock";
            this.txtShortCut01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSecondSpeed07
            // 
            this.cmbSecondSpeed07.FormattingEnabled = true;
            this.cmbSecondSpeed07.Location = new System.Drawing.Point(122, 225);
            this.cmbSecondSpeed07.Name = "cmbSecondSpeed07";
            this.cmbSecondSpeed07.Size = new System.Drawing.Size(50, 21);
            this.cmbSecondSpeed07.TabIndex = 84;
            this.cmbSecondSpeed07.SelectedIndexChanged += new System.EventHandler(this.cmbSecondSpeed07_SelectedIndexChanged);
            this.cmbSecondSpeed07.Resize += new System.EventHandler(this.cmbSecondSpeed07_Resize);
            // 
            // cmbSecondSpeed06
            // 
            this.cmbSecondSpeed06.FormattingEnabled = true;
            this.cmbSecondSpeed06.Location = new System.Drawing.Point(122, 199);
            this.cmbSecondSpeed06.Name = "cmbSecondSpeed06";
            this.cmbSecondSpeed06.Size = new System.Drawing.Size(50, 21);
            this.cmbSecondSpeed06.TabIndex = 83;
            this.cmbSecondSpeed06.SelectedIndexChanged += new System.EventHandler(this.cmbSecondSpeed06_SelectedIndexChanged);
            // 
            // cmbSecondSpeed05
            // 
            this.cmbSecondSpeed05.FormattingEnabled = true;
            this.cmbSecondSpeed05.Location = new System.Drawing.Point(122, 173);
            this.cmbSecondSpeed05.Name = "cmbSecondSpeed05";
            this.cmbSecondSpeed05.Size = new System.Drawing.Size(50, 21);
            this.cmbSecondSpeed05.TabIndex = 82;
            this.cmbSecondSpeed05.SelectedIndexChanged += new System.EventHandler(this.cmbSecondSpeed05_SelectedIndexChanged);
            // 
            // cmbMiliSpeed04
            // 
            this.cmbMiliSpeed04.FormattingEnabled = true;
            this.cmbMiliSpeed04.Location = new System.Drawing.Point(122, 118);
            this.cmbMiliSpeed04.Name = "cmbMiliSpeed04";
            this.cmbMiliSpeed04.Size = new System.Drawing.Size(50, 21);
            this.cmbMiliSpeed04.TabIndex = 81;
            this.cmbMiliSpeed04.SelectedIndexChanged += new System.EventHandler(this.cmbMiliSpeed04_SelectedIndexChanged);
            // 
            // cmbMiliSpeed03
            // 
            this.cmbMiliSpeed03.FormattingEnabled = true;
            this.cmbMiliSpeed03.Location = new System.Drawing.Point(122, 92);
            this.cmbMiliSpeed03.Name = "cmbMiliSpeed03";
            this.cmbMiliSpeed03.Size = new System.Drawing.Size(50, 21);
            this.cmbMiliSpeed03.TabIndex = 80;
            this.cmbMiliSpeed03.SelectedIndexChanged += new System.EventHandler(this.cmbMiliSpeed03_SelectedIndexChanged);
            // 
            // cmbMiliSpeed02
            // 
            this.cmbMiliSpeed02.FormattingEnabled = true;
            this.cmbMiliSpeed02.Location = new System.Drawing.Point(122, 65);
            this.cmbMiliSpeed02.Name = "cmbMiliSpeed02";
            this.cmbMiliSpeed02.Size = new System.Drawing.Size(50, 21);
            this.cmbMiliSpeed02.TabIndex = 79;
            this.cmbMiliSpeed02.SelectedIndexChanged += new System.EventHandler(this.cmbMiliSpeed02_SelectedIndexChanged);
            // 
            // cmbMiliSpeed01
            // 
            this.cmbMiliSpeed01.FormattingEnabled = true;
            this.cmbMiliSpeed01.Location = new System.Drawing.Point(122, 39);
            this.cmbMiliSpeed01.Name = "cmbMiliSpeed01";
            this.cmbMiliSpeed01.Size = new System.Drawing.Size(50, 21);
            this.cmbMiliSpeed01.TabIndex = 78;
            this.cmbMiliSpeed01.SelectedIndexChanged += new System.EventHandler(this.cmbMiliSpeed01_SelectedIndexChanged);
            // 
            // chcSkill07Active
            // 
            this.chcSkill07Active.AutoSize = true;
            this.chcSkill07Active.Location = new System.Drawing.Point(191, 228);
            this.chcSkill07Active.Name = "chcSkill07Active";
            this.chcSkill07Active.Size = new System.Drawing.Size(15, 14);
            this.chcSkill07Active.TabIndex = 76;
            this.chcSkill07Active.UseVisualStyleBackColor = true;
            this.chcSkill07Active.CheckedChanged += new System.EventHandler(this.chcSkill07Active_CheckedChanged);
            // 
            // txtSecondSkillActive
            // 
            this.txtSecondSkillActive.Location = new System.Drawing.Point(176, 157);
            this.txtSecondSkillActive.Name = "txtSecondSkillActive";
            this.txtSecondSkillActive.Size = new System.Drawing.Size(42, 13);
            this.txtSecondSkillActive.TabIndex = 77;
            this.txtSecondSkillActive.Text = "Aktif";
            this.txtSecondSkillActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edtSkill07
            // 
            this.edtSkill07.Enabled = false;
            this.edtSkill07.Location = new System.Drawing.Point(62, 225);
            this.edtSkill07.Name = "edtSkill07";
            this.edtSkill07.Size = new System.Drawing.Size(42, 20);
            this.edtSkill07.TabIndex = 73;
            this.edtSkill07.Text = "7";
            this.edtSkill07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSpeedSecond
            // 
            this.txtSpeedSecond.Location = new System.Drawing.Point(128, 157);
            this.txtSpeedSecond.Name = "txtSpeedSecond";
            this.txtSpeedSecond.Size = new System.Drawing.Size(42, 13);
            this.txtSpeedSecond.TabIndex = 75;
            this.txtSpeedSecond.Text = "Hız(sn)";
            this.txtSpeedSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSkill07
            // 
            this.txtSkill07.AutoSize = true;
            this.txtSkill07.Location = new System.Drawing.Point(18, 228);
            this.txtSkill07.Name = "txtSkill07";
            this.txtSkill07.Size = new System.Drawing.Size(36, 13);
            this.txtSkill07.TabIndex = 71;
            this.txtSkill07.Text = "Minor:";
            this.txtSkill07.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(62, 157);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(42, 13);
            this.txtNumber2.TabIndex = 74;
            this.txtNumber2.Text = "Tuş";
            this.txtNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartBasic
            // 
            this.btnStartBasic.Location = new System.Drawing.Point(122, 261);
            this.btnStartBasic.Name = "btnStartBasic";
            this.btnStartBasic.Size = new System.Drawing.Size(75, 40);
            this.btnStartBasic.TabIndex = 72;
            this.btnStartBasic.Text = "Z-R Skillsiz Başlat";
            this.btnStartBasic.UseVisualStyleBackColor = true;
            this.btnStartBasic.Click += new System.EventHandler(this.btnStartBasic_Click);
            // 
            // btnStartSkills
            // 
            this.btnStartSkills.Location = new System.Drawing.Point(41, 261);
            this.btnStartSkills.Name = "btnStartSkills";
            this.btnStartSkills.Size = new System.Drawing.Size(75, 40);
            this.btnStartSkills.TabIndex = 70;
            this.btnStartSkills.Text = "Skillerle Başlat";
            this.btnStartSkills.UseVisualStyleBackColor = true;
            this.btnStartSkills.Click += new System.EventHandler(this.btnStartSkills_Click);
            // 
            // chcSkill06Active
            // 
            this.chcSkill06Active.AutoSize = true;
            this.chcSkill06Active.Location = new System.Drawing.Point(191, 202);
            this.chcSkill06Active.Name = "chcSkill06Active";
            this.chcSkill06Active.Size = new System.Drawing.Size(15, 14);
            this.chcSkill06Active.TabIndex = 69;
            this.chcSkill06Active.UseVisualStyleBackColor = true;
            this.chcSkill06Active.CheckedChanged += new System.EventHandler(this.chcSkill06Active_CheckedChanged);
            // 
            // chcSkill05Active
            // 
            this.chcSkill05Active.AutoSize = true;
            this.chcSkill05Active.Location = new System.Drawing.Point(191, 176);
            this.chcSkill05Active.Name = "chcSkill05Active";
            this.chcSkill05Active.Size = new System.Drawing.Size(15, 14);
            this.chcSkill05Active.TabIndex = 66;
            this.chcSkill05Active.UseVisualStyleBackColor = true;
            this.chcSkill05Active.CheckedChanged += new System.EventHandler(this.chcSkill05Active_CheckedChanged);
            // 
            // edtSkill06
            // 
            this.edtSkill06.Enabled = false;
            this.edtSkill06.Location = new System.Drawing.Point(62, 199);
            this.edtSkill06.Name = "edtSkill06";
            this.edtSkill06.Size = new System.Drawing.Size(42, 20);
            this.edtSkill06.TabIndex = 68;
            this.edtSkill06.Text = "6";
            this.edtSkill06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSkill06
            // 
            this.txtSkill06.AutoSize = true;
            this.txtSkill06.Location = new System.Drawing.Point(18, 202);
            this.txtSkill06.Name = "txtSkill06";
            this.txtSkill06.Size = new System.Drawing.Size(45, 13);
            this.txtSkill06.TabIndex = 67;
            this.txtSkill06.Text = "MP Pot:";
            this.txtSkill06.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chcSkill04Active
            // 
            this.chcSkill04Active.AutoSize = true;
            this.chcSkill04Active.Location = new System.Drawing.Point(191, 121);
            this.chcSkill04Active.Name = "chcSkill04Active";
            this.chcSkill04Active.Size = new System.Drawing.Size(15, 14);
            this.chcSkill04Active.TabIndex = 63;
            this.chcSkill04Active.UseVisualStyleBackColor = true;
            this.chcSkill04Active.CheckedChanged += new System.EventHandler(this.chcSkill04Active_CheckedChanged);
            // 
            // edtSkill05
            // 
            this.edtSkill05.Enabled = false;
            this.edtSkill05.Location = new System.Drawing.Point(62, 173);
            this.edtSkill05.Name = "edtSkill05";
            this.edtSkill05.Size = new System.Drawing.Size(42, 20);
            this.edtSkill05.TabIndex = 65;
            this.edtSkill05.Text = "5";
            this.edtSkill05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSkill05
            // 
            this.txtSkill05.AutoSize = true;
            this.txtSkill05.Location = new System.Drawing.Point(18, 176);
            this.txtSkill05.Name = "txtSkill05";
            this.txtSkill05.Size = new System.Drawing.Size(44, 13);
            this.txtSkill05.TabIndex = 64;
            this.txtSkill05.Text = "HP Pot:";
            this.txtSkill05.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chcSkill03Active
            // 
            this.chcSkill03Active.AutoSize = true;
            this.chcSkill03Active.Location = new System.Drawing.Point(191, 95);
            this.chcSkill03Active.Name = "chcSkill03Active";
            this.chcSkill03Active.Size = new System.Drawing.Size(15, 14);
            this.chcSkill03Active.TabIndex = 60;
            this.chcSkill03Active.UseVisualStyleBackColor = true;
            this.chcSkill03Active.CheckedChanged += new System.EventHandler(this.chcSkill03Active_CheckedChanged);
            // 
            // edtSkill04
            // 
            this.edtSkill04.Enabled = false;
            this.edtSkill04.Location = new System.Drawing.Point(62, 118);
            this.edtSkill04.Name = "edtSkill04";
            this.edtSkill04.Size = new System.Drawing.Size(42, 20);
            this.edtSkill04.TabIndex = 62;
            this.edtSkill04.Text = "4";
            this.edtSkill04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSkill04
            // 
            this.txtSkill04.AutoSize = true;
            this.txtSkill04.Location = new System.Drawing.Point(18, 121);
            this.txtSkill04.Name = "txtSkill04";
            this.txtSkill04.Size = new System.Drawing.Size(38, 13);
            this.txtSkill04.TabIndex = 61;
            this.txtSkill04.Text = "Skill 4:";
            this.txtSkill04.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // edtSkill03
            // 
            this.edtSkill03.Enabled = false;
            this.edtSkill03.Location = new System.Drawing.Point(62, 92);
            this.edtSkill03.Name = "edtSkill03";
            this.edtSkill03.Size = new System.Drawing.Size(42, 20);
            this.edtSkill03.TabIndex = 59;
            this.edtSkill03.Text = "3";
            this.edtSkill03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chcSkill02Active
            // 
            this.chcSkill02Active.AutoSize = true;
            this.chcSkill02Active.Location = new System.Drawing.Point(191, 69);
            this.chcSkill02Active.Name = "chcSkill02Active";
            this.chcSkill02Active.Size = new System.Drawing.Size(15, 14);
            this.chcSkill02Active.TabIndex = 57;
            this.chcSkill02Active.UseVisualStyleBackColor = true;
            this.chcSkill02Active.CheckedChanged += new System.EventHandler(this.chcSkill02Active_CheckedChanged);
            // 
            // txtSkill03
            // 
            this.txtSkill03.AutoSize = true;
            this.txtSkill03.Location = new System.Drawing.Point(18, 95);
            this.txtSkill03.Name = "txtSkill03";
            this.txtSkill03.Size = new System.Drawing.Size(38, 13);
            this.txtSkill03.TabIndex = 58;
            this.txtSkill03.Text = "Skill 3:";
            this.txtSkill03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // edtSkill02
            // 
            this.edtSkill02.Enabled = false;
            this.edtSkill02.Location = new System.Drawing.Point(62, 66);
            this.edtSkill02.Name = "edtSkill02";
            this.edtSkill02.Size = new System.Drawing.Size(42, 20);
            this.edtSkill02.TabIndex = 56;
            this.edtSkill02.Text = "2";
            this.edtSkill02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSkillActive
            // 
            this.txtSkillActive.Location = new System.Drawing.Point(176, 24);
            this.txtSkillActive.Name = "txtSkillActive";
            this.txtSkillActive.Size = new System.Drawing.Size(42, 13);
            this.txtSkillActive.TabIndex = 54;
            this.txtSkillActive.Text = "Aktif";
            this.txtSkillActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSkill02
            // 
            this.txtSkill02.AutoSize = true;
            this.txtSkill02.Location = new System.Drawing.Point(18, 69);
            this.txtSkill02.Name = "txtSkill02";
            this.txtSkill02.Size = new System.Drawing.Size(38, 13);
            this.txtSkill02.TabIndex = 55;
            this.txtSkill02.Text = "Skill 2:";
            this.txtSkill02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chcSkill01Active
            // 
            this.chcSkill01Active.AutoSize = true;
            this.chcSkill01Active.Location = new System.Drawing.Point(191, 43);
            this.chcSkill01Active.Name = "chcSkill01Active";
            this.chcSkill01Active.Size = new System.Drawing.Size(15, 14);
            this.chcSkill01Active.TabIndex = 53;
            this.chcSkill01Active.UseVisualStyleBackColor = true;
            this.chcSkill01Active.CheckedChanged += new System.EventHandler(this.chcSkill01Active_CheckedChanged);
            // 
            // txtSpeedMiliSecond
            // 
            this.txtSpeedMiliSecond.Location = new System.Drawing.Point(128, 24);
            this.txtSpeedMiliSecond.Name = "txtSpeedMiliSecond";
            this.txtSpeedMiliSecond.Size = new System.Drawing.Size(42, 13);
            this.txtSpeedMiliSecond.TabIndex = 52;
            this.txtSpeedMiliSecond.Text = "Hız(ms)";
            this.txtSpeedMiliSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(62, 24);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(42, 13);
            this.txtNumber.TabIndex = 51;
            this.txtNumber.Text = "Tuş";
            this.txtNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edtSkill01
            // 
            this.edtSkill01.Enabled = false;
            this.edtSkill01.Location = new System.Drawing.Point(62, 40);
            this.edtSkill01.Name = "edtSkill01";
            this.edtSkill01.Size = new System.Drawing.Size(42, 20);
            this.edtSkill01.TabIndex = 50;
            this.edtSkill01.Text = "1";
            this.edtSkill01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSkill01
            // 
            this.txtSkill01.AutoSize = true;
            this.txtSkill01.Location = new System.Drawing.Point(18, 43);
            this.txtSkill01.Name = "txtSkill01";
            this.txtSkill01.Size = new System.Drawing.Size(38, 13);
            this.txtSkill01.TabIndex = 49;
            this.txtSkill01.Text = "Skill 1:";
            this.txtSkill01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Arkaplanda çalışmaya devam ediyor.";
            this.notifyIcon1.BalloonTipTitle = "Macro Editor v1.0";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Macro";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 67);
            this.label1.TabIndex = 88;
            this.label1.Text = "NOT: 2dk lık skiller için 120128ms, 5dklık skiller için 300128ms, 10dklık skiller" +
    " için 600128ms\r\nPotlar için sn cinsinden 180sn = 3dk...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmKOmacro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtShortCut02);
            this.Controls.Add(this.txtShortCut01);
            this.Controls.Add(this.cmbSecondSpeed07);
            this.Controls.Add(this.cmbSecondSpeed06);
            this.Controls.Add(this.cmbSecondSpeed05);
            this.Controls.Add(this.cmbMiliSpeed04);
            this.Controls.Add(this.cmbMiliSpeed03);
            this.Controls.Add(this.cmbMiliSpeed02);
            this.Controls.Add(this.cmbMiliSpeed01);
            this.Controls.Add(this.chcSkill07Active);
            this.Controls.Add(this.txtSecondSkillActive);
            this.Controls.Add(this.edtSkill07);
            this.Controls.Add(this.txtSpeedSecond);
            this.Controls.Add(this.txtSkill07);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.btnStartBasic);
            this.Controls.Add(this.btnStartSkills);
            this.Controls.Add(this.chcSkill06Active);
            this.Controls.Add(this.chcSkill05Active);
            this.Controls.Add(this.edtSkill06);
            this.Controls.Add(this.txtSkill06);
            this.Controls.Add(this.chcSkill04Active);
            this.Controls.Add(this.edtSkill05);
            this.Controls.Add(this.txtSkill05);
            this.Controls.Add(this.chcSkill03Active);
            this.Controls.Add(this.edtSkill04);
            this.Controls.Add(this.txtSkill04);
            this.Controls.Add(this.edtSkill03);
            this.Controls.Add(this.chcSkill02Active);
            this.Controls.Add(this.txtSkill03);
            this.Controls.Add(this.edtSkill02);
            this.Controls.Add(this.txtSkillActive);
            this.Controls.Add(this.txtSkill02);
            this.Controls.Add(this.chcSkill01Active);
            this.Controls.Add(this.txtSpeedMiliSecond);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.edtSkill01);
            this.Controls.Add(this.txtSkill01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmKOmacro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Macro Editor";
            this.Load += new System.EventHandler(this.frmKOmacro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtInfo;
        private System.Windows.Forms.Label txtShortCut02;
        private System.Windows.Forms.Label txtShortCut01;
        private System.Windows.Forms.ComboBox cmbSecondSpeed07;
        private System.Windows.Forms.ComboBox cmbSecondSpeed06;
        private System.Windows.Forms.ComboBox cmbSecondSpeed05;
        private System.Windows.Forms.ComboBox cmbMiliSpeed04;
        private System.Windows.Forms.ComboBox cmbMiliSpeed03;
        private System.Windows.Forms.ComboBox cmbMiliSpeed02;
        private System.Windows.Forms.ComboBox cmbMiliSpeed01;
        private System.Windows.Forms.CheckBox chcSkill07Active;
        private System.Windows.Forms.Label txtSecondSkillActive;
        private System.Windows.Forms.TextBox edtSkill07;
        private System.Windows.Forms.Label txtSpeedSecond;
        private System.Windows.Forms.Label txtSkill07;
        private System.Windows.Forms.Label txtNumber2;
        private System.Windows.Forms.Button btnStartBasic;
        private System.Windows.Forms.Button btnStartSkills;
        private System.Windows.Forms.CheckBox chcSkill06Active;
        private System.Windows.Forms.CheckBox chcSkill05Active;
        private System.Windows.Forms.TextBox edtSkill06;
        private System.Windows.Forms.Label txtSkill06;
        private System.Windows.Forms.CheckBox chcSkill04Active;
        private System.Windows.Forms.TextBox edtSkill05;
        private System.Windows.Forms.Label txtSkill05;
        private System.Windows.Forms.CheckBox chcSkill03Active;
        private System.Windows.Forms.TextBox edtSkill04;
        private System.Windows.Forms.Label txtSkill04;
        private System.Windows.Forms.TextBox edtSkill03;
        private System.Windows.Forms.CheckBox chcSkill02Active;
        private System.Windows.Forms.Label txtSkill03;
        private System.Windows.Forms.TextBox edtSkill02;
        private System.Windows.Forms.Label txtSkillActive;
        private System.Windows.Forms.Label txtSkill02;
        private System.Windows.Forms.CheckBox chcSkill01Active;
        private System.Windows.Forms.Label txtSpeedMiliSecond;
        private System.Windows.Forms.Label txtNumber;
        private System.Windows.Forms.TextBox edtSkill01;
        private System.Windows.Forms.Label txtSkill01;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
    }
}

