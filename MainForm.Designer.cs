

#region using statements


#endregion

namespace PythonClassCreator
{

    #region class MainForm
    /// <summary>
    /// This is the designer for this application.
    /// </summary>
    partial class MainForm
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        private DataJuggler.Win.Controls.LabelTextBoxControl PropertyNameTextBox;
        private DataJuggler.Win.Controls.Button CreateClassButton;
        private ListBox PropertiesList;
        private DataJuggler.Win.Controls.Button AddButton;
        private DataJuggler.Win.Controls.Button EditButton;
        private DataJuggler.Win.Controls.Button DeleteButton;
        private DataJuggler.Win.Controls.Button CancelSaveButton;
        private DataJuggler.Win.Controls.Button SaveButton;
        private DataJuggler.Win.Controls.LabelTextBoxControl ClassNameTextBox;
        private Label StatusLabel;
        #endregion
        
        #region Methods
            
            #region Dispose(bool disposing)
            /// <summary>
            ///  Clean up any resources being used.
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
            #endregion
            
            #region InitializeComponent()
            /// <summary>
            ///  Required method for Designer support - do not modify
            ///  the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PropertyNameTextBox = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.CreateClassButton = new DataJuggler.Win.Controls.Button();
            this.PropertiesList = new System.Windows.Forms.ListBox();
            this.AddButton = new DataJuggler.Win.Controls.Button();
            this.EditButton = new DataJuggler.Win.Controls.Button();
            this.DeleteButton = new DataJuggler.Win.Controls.Button();
            this.CancelSaveButton = new DataJuggler.Win.Controls.Button();
            this.SaveButton = new DataJuggler.Win.Controls.Button();
            this.ClassNameTextBox = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.DefaultValueTextBox = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PropertyNameTextBox
            // 
            this.PropertyNameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.PropertyNameTextBox.BottomMargin = 0;
            this.PropertyNameTextBox.Editable = true;
            this.PropertyNameTextBox.Encrypted = false;
            this.PropertyNameTextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PropertyNameTextBox.Inititialized = true;
            this.PropertyNameTextBox.LabelBottomMargin = 0;
            this.PropertyNameTextBox.LabelColor = System.Drawing.Color.LemonChiffon;
            this.PropertyNameTextBox.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PropertyNameTextBox.LabelText = "Property Name:";
            this.PropertyNameTextBox.LabelTopMargin = 0;
            this.PropertyNameTextBox.LabelWidth = 160;
            this.PropertyNameTextBox.Location = new System.Drawing.Point(90, 68);
            this.PropertyNameTextBox.MultiLine = false;
            this.PropertyNameTextBox.Name = "PropertyNameTextBox";
            this.PropertyNameTextBox.OnTextChangedListener = null;
            this.PropertyNameTextBox.PasswordMode = false;
            this.PropertyNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PropertyNameTextBox.Size = new System.Drawing.Size(360, 32);
            this.PropertyNameTextBox.TabIndex = 1;
            this.PropertyNameTextBox.TextBoxBottomMargin = 0;
            this.PropertyNameTextBox.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.PropertyNameTextBox.TextBoxEditableColor = System.Drawing.Color.White;
            this.PropertyNameTextBox.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PropertyNameTextBox.TextBoxTopMargin = 0;
            this.PropertyNameTextBox.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // CreateClassButton
            // 
            this.CreateClassButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateClassButton.ButtonText = "Create Class";
            this.CreateClassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateClassButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateClassButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.CreateClassButton.Location = new System.Drawing.Point(483, 179);
            this.CreateClassButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateClassButton.Name = "CreateClassButton";
            this.CreateClassButton.Size = new System.Drawing.Size(211, 36);
            this.CreateClassButton.TabIndex = 8;
            this.CreateClassButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.CreateClassButton.Click += new System.EventHandler(this.CreateClassButton_Click);
            // 
            // PropertiesList
            // 
            this.PropertiesList.FormattingEnabled = true;
            this.PropertiesList.ItemHeight = 18;
            this.PropertiesList.Location = new System.Drawing.Point(90, 179);
            this.PropertiesList.Name = "PropertiesList";
            this.PropertiesList.Size = new System.Drawing.Size(360, 274);
            this.PropertiesList.TabIndex = 2;
            this.PropertiesList.SelectedIndexChanged += new System.EventHandler(this.PropertiesList_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.ButtonText = "Add";
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.AddButton.Location = new System.Drawing.Point(107, 471);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(96, 36);
            this.AddButton.TabIndex = 5;
            this.AddButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Transparent;
            this.EditButton.ButtonText = "Edit";
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.EditButton.Location = new System.Drawing.Point(222, 471);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(96, 36);
            this.EditButton.TabIndex = 6;
            this.EditButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.ButtonText = "Delete";
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.DeleteButton.Location = new System.Drawing.Point(338, 471);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(96, 36);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CancelSaveButton
            // 
            this.CancelSaveButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelSaveButton.ButtonText = "Cancel";
            this.CancelSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelSaveButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelSaveButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.CancelSaveButton.Location = new System.Drawing.Point(598, 60);
            this.CancelSaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelSaveButton.Name = "CancelSaveButton";
            this.CancelSaveButton.Size = new System.Drawing.Size(96, 36);
            this.CancelSaveButton.TabIndex = 4;
            this.CancelSaveButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.CancelSaveButton.Click += new System.EventHandler(this.CancelSaveButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.ButtonText = "Save";
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.SaveButton.Location = new System.Drawing.Point(483, 60);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(96, 36);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ClassNameTextBox
            // 
            this.ClassNameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.ClassNameTextBox.BottomMargin = 0;
            this.ClassNameTextBox.Editable = true;
            this.ClassNameTextBox.Encrypted = false;
            this.ClassNameTextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClassNameTextBox.Inititialized = true;
            this.ClassNameTextBox.LabelBottomMargin = 0;
            this.ClassNameTextBox.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ClassNameTextBox.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClassNameTextBox.LabelText = "Class Name:";
            this.ClassNameTextBox.LabelTopMargin = 0;
            this.ClassNameTextBox.LabelWidth = 160;
            this.ClassNameTextBox.Location = new System.Drawing.Point(90, 24);
            this.ClassNameTextBox.MultiLine = false;
            this.ClassNameTextBox.Name = "ClassNameTextBox";
            this.ClassNameTextBox.OnTextChangedListener = null;
            this.ClassNameTextBox.PasswordMode = false;
            this.ClassNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ClassNameTextBox.Size = new System.Drawing.Size(360, 32);
            this.ClassNameTextBox.TabIndex = 0;
            this.ClassNameTextBox.TextBoxBottomMargin = 0;
            this.ClassNameTextBox.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.ClassNameTextBox.TextBoxEditableColor = System.Drawing.Color.White;
            this.ClassNameTextBox.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClassNameTextBox.TextBoxTopMargin = 0;
            this.ClassNameTextBox.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.StatusLabel.Location = new System.Drawing.Point(0, 534);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(740, 37);
            this.StatusLabel.TabIndex = 9;
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DefaultValueTextBox
            // 
            this.DefaultValueTextBox.BackColor = System.Drawing.Color.Transparent;
            this.DefaultValueTextBox.BottomMargin = 0;
            this.DefaultValueTextBox.Editable = true;
            this.DefaultValueTextBox.Encrypted = false;
            this.DefaultValueTextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DefaultValueTextBox.Inititialized = true;
            this.DefaultValueTextBox.LabelBottomMargin = 0;
            this.DefaultValueTextBox.LabelColor = System.Drawing.Color.LemonChiffon;
            this.DefaultValueTextBox.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DefaultValueTextBox.LabelText = "Default Value:";
            this.DefaultValueTextBox.LabelTopMargin = 0;
            this.DefaultValueTextBox.LabelWidth = 160;
            this.DefaultValueTextBox.Location = new System.Drawing.Point(90, 115);
            this.DefaultValueTextBox.MultiLine = false;
            this.DefaultValueTextBox.Name = "DefaultValueTextBox";
            this.DefaultValueTextBox.OnTextChangedListener = null;
            this.DefaultValueTextBox.PasswordMode = false;
            this.DefaultValueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DefaultValueTextBox.Size = new System.Drawing.Size(360, 32);
            this.DefaultValueTextBox.TabIndex = 2;
            this.DefaultValueTextBox.TextBoxBottomMargin = 0;
            this.DefaultValueTextBox.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.DefaultValueTextBox.TextBoxEditableColor = System.Drawing.Color.White;
            this.DefaultValueTextBox.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DefaultValueTextBox.TextBoxTopMargin = 0;
            this.DefaultValueTextBox.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // InfoLabel
            // 
            this.InfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.InfoLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.InfoLabel.Location = new System.Drawing.Point(485, 234);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(209, 273);
            this.InfoLabel.TabIndex = 10;
            this.InfoLabel.Text = "1. Enter a Class Name.\r\n2. Click the Add gutton\r\n3. Enter Property Name\r\n4. Enter" +
    " Default Value\r\n5. Click Save.\r\n6. Repeat as needed\r\n7. Click Create Class\r\n\r\n";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::PythonClassCreator.Properties.Resources.BlackImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 571);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.DefaultValueTextBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ClassNameTextBox);
            this.Controls.Add(this.CancelSaveButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PropertiesList);
            this.Controls.Add(this.CreateClassButton);
            this.Controls.Add(this.PropertyNameTextBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Python Class Creator";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.ResumeLayout(false);

            }
        #endregion

        #endregion

        private DataJuggler.Win.Controls.LabelTextBoxControl DefaultValueTextBox;
        private Label InfoLabel;
    }
    #endregion

}
