namespace My_First_PIZZA_Project
{
    partial class frmForm1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForm1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.rdMedium = new System.Windows.Forms.RadioButton();
            this.rdLarge = new System.Windows.Forms.RadioButton();
            this.grSize = new System.Windows.Forms.GroupBox();
            this.grType = new System.Windows.Forms.GroupBox();
            this.rdThickCrust = new System.Windows.Forms.RadioButton();
            this.rdThinCrust = new System.Windows.Forms.RadioButton();
            this.rdTakeOut = new System.Windows.Forms.RadioButton();
            this.rdEatIn = new System.Windows.Forms.RadioButton();
            this.grPlaceToEat = new System.Windows.Forms.GroupBox();
            this.lb = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbToppings = new System.Windows.Forms.Label();
            this.lbPrise = new System.Windows.Forms.Label();
            this.lbCrustType = new System.Windows.Forms.Label();
            this.lbWhereToEat = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btOrderPizza = new System.Windows.Forms.Button();
            this.btResetForm = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtToppings = new System.Windows.Forms.TextBox();
            this.txtCrustType = new System.Windows.Forms.TextBox();
            this.txtWhereToEat = new System.Windows.Forms.TextBox();
            this.txtPrise = new System.Windows.Forms.TextBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.grToppings = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grSize.SuspendLayout();
            this.grType.SuspendLayout();
            this.grPlaceToEat.SuspendLayout();
            this.grToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 352);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(629, 219);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.BackColor = System.Drawing.Color.RosyBrown;
            this.rdSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSmall.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rdSmall.Location = new System.Drawing.Point(16, 30);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(67, 20);
            this.rdSmall.TabIndex = 2;
            this.rdSmall.TabStop = true;
            this.rdSmall.Text = "Small";
            this.rdSmall.UseVisualStyleBackColor = false;
            this.rdSmall.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rdSmall_MouseDown);
            // 
            // rdMedium
            // 
            this.rdMedium.AutoSize = true;
            this.rdMedium.BackColor = System.Drawing.Color.RosyBrown;
            this.rdMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMedium.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rdMedium.Location = new System.Drawing.Point(16, 56);
            this.rdMedium.Name = "rdMedium";
            this.rdMedium.Size = new System.Drawing.Size(82, 20);
            this.rdMedium.TabIndex = 3;
            this.rdMedium.TabStop = true;
            this.rdMedium.Text = "Medium";
            this.rdMedium.UseVisualStyleBackColor = false;
            this.rdMedium.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rdMedium_MouseDown);
            // 
            // rdLarge
            // 
            this.rdLarge.AutoSize = true;
            this.rdLarge.BackColor = System.Drawing.Color.RosyBrown;
            this.rdLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLarge.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rdLarge.Location = new System.Drawing.Point(16, 82);
            this.rdLarge.Name = "rdLarge";
            this.rdLarge.Size = new System.Drawing.Size(68, 20);
            this.rdLarge.TabIndex = 4;
            this.rdLarge.TabStop = true;
            this.rdLarge.Text = "Large";
            this.rdLarge.UseVisualStyleBackColor = false;
            this.rdLarge.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rdLarge_MouseDown);
            // 
            // grSize
            // 
            this.grSize.BackColor = System.Drawing.Color.Black;
            this.grSize.Controls.Add(this.rdSmall);
            this.grSize.Controls.Add(this.rdLarge);
            this.grSize.Controls.Add(this.rdMedium);
            this.grSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grSize.ForeColor = System.Drawing.SystemColors.Window;
            this.grSize.Location = new System.Drawing.Point(28, 81);
            this.grSize.Name = "grSize";
            this.grSize.Size = new System.Drawing.Size(135, 136);
            this.grSize.TabIndex = 5;
            this.grSize.TabStop = false;
            this.grSize.Text = "Size";
            // 
            // grType
            // 
            this.grType.BackColor = System.Drawing.Color.Black;
            this.grType.Controls.Add(this.rdThickCrust);
            this.grType.Controls.Add(this.rdThinCrust);
            this.grType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grType.ForeColor = System.Drawing.Color.YellowGreen;
            this.grType.Location = new System.Drawing.Point(76, 249);
            this.grType.Name = "grType";
            this.grType.Size = new System.Drawing.Size(140, 105);
            this.grType.TabIndex = 7;
            this.grType.TabStop = false;
            this.grType.Text = "Crust Type";
            // 
            // rdThickCrust
            // 
            this.rdThickCrust.AutoSize = true;
            this.rdThickCrust.BackColor = System.Drawing.Color.Black;
            this.rdThickCrust.ForeColor = System.Drawing.Color.White;
            this.rdThickCrust.Location = new System.Drawing.Point(16, 68);
            this.rdThickCrust.Name = "rdThickCrust";
            this.rdThickCrust.Size = new System.Drawing.Size(116, 22);
            this.rdThickCrust.TabIndex = 9;
            this.rdThickCrust.TabStop = true;
            this.rdThickCrust.Text = "Thick Crust";
            this.rdThickCrust.UseVisualStyleBackColor = false;
            this.rdThickCrust.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rdThickCrust_MouseDown);
            // 
            // rdThinCrust
            // 
            this.rdThinCrust.AutoSize = true;
            this.rdThinCrust.BackColor = System.Drawing.Color.Black;
            this.rdThinCrust.ForeColor = System.Drawing.Color.White;
            this.rdThinCrust.Location = new System.Drawing.Point(16, 32);
            this.rdThinCrust.Name = "rdThinCrust";
            this.rdThinCrust.Size = new System.Drawing.Size(107, 22);
            this.rdThinCrust.TabIndex = 8;
            this.rdThinCrust.TabStop = true;
            this.rdThinCrust.Text = "Thin Crust";
            this.rdThinCrust.UseVisualStyleBackColor = false;
            this.rdThinCrust.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rdThinCrust_MouseDown);
            // 
            // rdTakeOut
            // 
            this.rdTakeOut.AutoSize = true;
            this.rdTakeOut.BackColor = System.Drawing.Color.Black;
            this.rdTakeOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdTakeOut.Location = new System.Drawing.Point(122, 32);
            this.rdTakeOut.Name = "rdTakeOut";
            this.rdTakeOut.Size = new System.Drawing.Size(95, 22);
            this.rdTakeOut.TabIndex = 9;
            this.rdTakeOut.TabStop = true;
            this.rdTakeOut.Text = "Take out";
            this.rdTakeOut.UseVisualStyleBackColor = false;
            this.rdTakeOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rdTakeOut_MouseDown);
            // 
            // rdEatIn
            // 
            this.rdEatIn.AutoSize = true;
            this.rdEatIn.BackColor = System.Drawing.Color.Black;
            this.rdEatIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdEatIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdEatIn.Location = new System.Drawing.Point(6, 32);
            this.rdEatIn.Name = "rdEatIn";
            this.rdEatIn.Size = new System.Drawing.Size(67, 20);
            this.rdEatIn.TabIndex = 10;
            this.rdEatIn.TabStop = true;
            this.rdEatIn.Text = "Eat In";
            this.rdEatIn.UseVisualStyleBackColor = false;
            this.rdEatIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rdEatIn_MouseDown);
            // 
            // grPlaceToEat
            // 
            this.grPlaceToEat.BackColor = System.Drawing.Color.Black;
            this.grPlaceToEat.Controls.Add(this.rdEatIn);
            this.grPlaceToEat.Controls.Add(this.rdTakeOut);
            this.grPlaceToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grPlaceToEat.ForeColor = System.Drawing.Color.YellowGreen;
            this.grPlaceToEat.Location = new System.Drawing.Point(305, 260);
            this.grPlaceToEat.Name = "grPlaceToEat";
            this.grPlaceToEat.Size = new System.Drawing.Size(247, 78);
            this.grPlaceToEat.TabIndex = 11;
            this.grPlaceToEat.TabStop = false;
            this.grPlaceToEat.Text = "Where to Eat";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.Coral;
            this.lb.Location = new System.Drawing.Point(693, 91);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(128, 20);
            this.lb.TabIndex = 12;
            this.lb.Text = "Order Summary";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.ForeColor = System.Drawing.Color.Coral;
            this.lbSize.Location = new System.Drawing.Point(714, 130);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(60, 27);
            this.lbSize.TabIndex = 13;
            this.lbSize.Text = "Size: ";
            // 
            // lbToppings
            // 
            this.lbToppings.AutoSize = true;
            this.lbToppings.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppings.ForeColor = System.Drawing.Color.Coral;
            this.lbToppings.Location = new System.Drawing.Point(682, 164);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(92, 27);
            this.lbToppings.TabIndex = 14;
            this.lbToppings.Text = "Toppings";
            // 
            // lbPrise
            // 
            this.lbPrise.AutoSize = true;
            this.lbPrise.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrise.ForeColor = System.Drawing.Color.Coral;
            this.lbPrise.Location = new System.Drawing.Point(713, 384);
            this.lbPrise.Name = "lbPrise";
            this.lbPrise.Size = new System.Drawing.Size(68, 32);
            this.lbPrise.TabIndex = 15;
            this.lbPrise.Text = "Prise";
            // 
            // lbCrustType
            // 
            this.lbCrustType.AutoSize = true;
            this.lbCrustType.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrustType.ForeColor = System.Drawing.Color.Coral;
            this.lbCrustType.Location = new System.Drawing.Point(661, 227);
            this.lbCrustType.Name = "lbCrustType";
            this.lbCrustType.Size = new System.Drawing.Size(97, 23);
            this.lbCrustType.TabIndex = 16;
            this.lbCrustType.Text = "Crust Type";
            // 
            // lbWhereToEat
            // 
            this.lbWhereToEat.AutoSize = true;
            this.lbWhereToEat.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhereToEat.ForeColor = System.Drawing.Color.Coral;
            this.lbWhereToEat.Location = new System.Drawing.Point(683, 282);
            this.lbWhereToEat.Name = "lbWhereToEat";
            this.lbWhereToEat.Size = new System.Drawing.Size(117, 23);
            this.lbWhereToEat.TabIndex = 17;
            this.lbWhereToEat.Text = "Where To Eat";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Jokerman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(400, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(392, 63);
            this.lbTitle.TabIndex = 18;
            this.lbTitle.Text = "Make Your Pizza";
            // 
            // btOrderPizza
            // 
            this.btOrderPizza.BackColor = System.Drawing.Color.RosyBrown;
            this.btOrderPizza.Location = new System.Drawing.Point(798, 478);
            this.btOrderPizza.Name = "btOrderPizza";
            this.btOrderPizza.Size = new System.Drawing.Size(115, 78);
            this.btOrderPizza.TabIndex = 19;
            this.btOrderPizza.Text = "Order Pizza";
            this.btOrderPizza.UseVisualStyleBackColor = false;
            this.btOrderPizza.Click += new System.EventHandler(this.btOrderPizza_Click);
            // 
            // btResetForm
            // 
            this.btResetForm.BackColor = System.Drawing.Color.RosyBrown;
            this.btResetForm.Location = new System.Drawing.Point(970, 478);
            this.btResetForm.Name = "btResetForm";
            this.btResetForm.Size = new System.Drawing.Size(115, 78);
            this.btResetForm.TabIndex = 20;
            this.btResetForm.Text = "Reset Form";
            this.btResetForm.UseVisualStyleBackColor = false;
            this.btResetForm.Click += new System.EventHandler(this.btResetForm_Click);
            // 
            // txtSize
            // 
            this.txtSize.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtSize.Location = new System.Drawing.Point(793, 127);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 21);
            this.txtSize.TabIndex = 21;
            // 
            // txtToppings
            // 
            this.txtToppings.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtToppings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToppings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtToppings.Location = new System.Drawing.Point(536, 190);
            this.txtToppings.Name = "txtToppings";
            this.txtToppings.Size = new System.Drawing.Size(584, 17);
            this.txtToppings.TabIndex = 22;
            this.txtToppings.Text = "No Toppings";
            this.txtToppings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrustType
            // 
            this.txtCrustType.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCrustType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrustType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtCrustType.Location = new System.Drawing.Point(813, 230);
            this.txtCrustType.Name = "txtCrustType";
            this.txtCrustType.Size = new System.Drawing.Size(100, 21);
            this.txtCrustType.TabIndex = 23;
            // 
            // txtWhereToEat
            // 
            this.txtWhereToEat.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtWhereToEat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWhereToEat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtWhereToEat.Location = new System.Drawing.Point(758, 317);
            this.txtWhereToEat.Name = "txtWhereToEat";
            this.txtWhereToEat.Size = new System.Drawing.Size(100, 21);
            this.txtWhereToEat.TabIndex = 24;
            // 
            // txtPrise
            // 
            this.txtPrise.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPrise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrise.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtPrise.Location = new System.Drawing.Point(813, 366);
            this.txtPrise.Name = "txtPrise";
            this.txtPrise.Size = new System.Drawing.Size(155, 80);
            this.txtPrise.TabIndex = 25;
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.BackColor = System.Drawing.Color.RosyBrown;
            this.chkExtraChees.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraChees.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkExtraChees.Location = new System.Drawing.Point(21, 30);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(112, 20);
            this.chkExtraChees.TabIndex = 32;
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = false;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.BackColor = System.Drawing.Color.RosyBrown;
            this.chkMushrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushrooms.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkMushrooms.Location = new System.Drawing.Point(21, 67);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(108, 20);
            this.chkMushrooms.TabIndex = 33;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = false;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.BackColor = System.Drawing.Color.RosyBrown;
            this.chkGreenPeppers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenPeppers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkGreenPeppers.Location = new System.Drawing.Point(155, 106);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(134, 20);
            this.chkGreenPeppers.TabIndex = 37;
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = false;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.BackColor = System.Drawing.Color.RosyBrown;
            this.chkTomatoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomatoes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkTomatoes.Location = new System.Drawing.Point(21, 108);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(99, 20);
            this.chkTomatoes.TabIndex = 34;
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = false;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.BackColor = System.Drawing.Color.RosyBrown;
            this.chkOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlives.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkOlives.Location = new System.Drawing.Point(155, 67);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(73, 20);
            this.chkOlives.TabIndex = 36;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = false;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.BackColor = System.Drawing.Color.RosyBrown;
            this.chkOnion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkOnion.Location = new System.Drawing.Point(159, 21);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(69, 20);
            this.chkOnion.TabIndex = 35;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = false;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // grToppings
            // 
            this.grToppings.Controls.Add(this.chkExtraChees);
            this.grToppings.Controls.Add(this.chkOnion);
            this.grToppings.Controls.Add(this.chkMushrooms);
            this.grToppings.Controls.Add(this.chkOlives);
            this.grToppings.Controls.Add(this.chkTomatoes);
            this.grToppings.Controls.Add(this.chkGreenPeppers);
            this.grToppings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grToppings.Location = new System.Drawing.Point(226, 81);
            this.grToppings.Name = "grToppings";
            this.grToppings.Size = new System.Drawing.Size(289, 164);
            this.grToppings.TabIndex = 38;
            this.grToppings.TabStop = false;
            this.grToppings.Text = "Toppings";
            // 
            // frmForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1132, 583);
            this.Controls.Add(this.grToppings);
            this.Controls.Add(this.txtPrise);
            this.Controls.Add(this.txtWhereToEat);
            this.Controls.Add(this.txtCrustType);
            this.Controls.Add(this.txtToppings);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.btResetForm);
            this.Controls.Add(this.btOrderPizza);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbWhereToEat);
            this.Controls.Add(this.lbCrustType);
            this.Controls.Add(this.lbPrise);
            this.Controls.Add(this.lbToppings);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.grPlaceToEat);
            this.Controls.Add(this.grType);
            this.Controls.Add(this.grSize);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projet Pizza";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grSize.ResumeLayout(false);
            this.grSize.PerformLayout();
            this.grType.ResumeLayout(false);
            this.grType.PerformLayout();
            this.grPlaceToEat.ResumeLayout(false);
            this.grPlaceToEat.PerformLayout();
            this.grToppings.ResumeLayout(false);
            this.grToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.RadioButton rdMedium;
        private System.Windows.Forms.RadioButton rdLarge;
        private System.Windows.Forms.GroupBox grSize;
        private System.Windows.Forms.GroupBox grType;
        private System.Windows.Forms.RadioButton rdThickCrust;
        private System.Windows.Forms.RadioButton rdThinCrust;
        private System.Windows.Forms.RadioButton rdTakeOut;
        private System.Windows.Forms.RadioButton rdEatIn;
        private System.Windows.Forms.GroupBox grPlaceToEat;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.Label lbPrise;
        private System.Windows.Forms.Label lbCrustType;
        private System.Windows.Forms.Label lbWhereToEat;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btOrderPizza;
        private System.Windows.Forms.Button btResetForm;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtToppings;
        private System.Windows.Forms.TextBox txtCrustType;
        private System.Windows.Forms.TextBox txtWhereToEat;
        private System.Windows.Forms.TextBox txtPrise;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.GroupBox grToppings;
    }
}

