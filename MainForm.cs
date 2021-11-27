

#region using statements

using System.Text;
using PythonClassCreator.Enumerations;
using DataJuggler.UltimateHelper;

#endregion

namespace PythonClassCreator
{

    #region class MainForm
    /// <summary>
    /// This class is used to create Python classes
    /// </summary>
    public partial class MainForm : Form
    {
        
        #region Private Variables        
        private EditModeEnum editMode;
        private PythonProperty selectedItem;
        private bool startupComplete;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();

            // Setup the UI
            UIEnable();
        }
        #endregion
        
        #region Events
            
            #region AddButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'AddButton' is clicked.
            /// </summary>
            private void AddButton_Click(object sender, EventArgs e)
            {
                // Set EditMode
                EditMode = EditModeEnum.AddNew;

                // Enable controls
                UIEnable();

                // Create a new SelectedItem
                SelectedItem = new PythonProperty();

                // Set Focus
                PropertyNameTextBox.Text = "";
                PropertyNameTextBox.SetFocusToTextBox();
                DefaultValueTextBox.Text = "None";
            }
            #endregion
            
            #region CancelSaveButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'CancelSaveButton' is clicked.
            /// </summary>
            private void CancelSaveButton_Click(object sender, EventArgs e)
            {
                // if add new
                if (EditMode == EditModeEnum.AddNew)
                {
                    // Erase
                    PropertyNameTextBox.Text = "";
                }

                // Back to read only
                EditMode = EditModeEnum.NotSet;

                // Enable or disable controls
                UIEnable();
            }
            #endregion
            
            #region CreateClassButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'CreateClassButton' is clicked.
            /// </summary>
            private void CreateClassButton_Click(object sender, EventArgs e)
            {
                StringBuilder sb = new StringBuilder();
                
                string indent = TextHelper.Indent(4);
                string indent2 = TextHelper.Indent(8);
                
                sb.Append("class ");
                sb.Append(ClassNameTextBox.Text);
                sb.Append(":");
                sb.Append(Environment.NewLine);

                // now the constructor
                sb.Append(indent);
                sb.Append("def __init__(self):");
                sb.Append(Environment.NewLine);
                
                // if there are one or more items
                if (ListHelper.HasOneOrMoreItems(PropertiesList.Items))
                {
                    // add each property
                    foreach (object item in PropertiesList.Items)
                    {
                        // cast the object as a PythonProperty
                        PythonProperty pythonProperty = item as PythonProperty;

                        // If the pythonProperty object exists
                        if (NullHelper.Exists(pythonProperty))
                        {
                            sb.Append(indent2);
                            sb.Append("self.__");
                            sb.Append(item);
                            sb.Append(" = ");
                            sb.Append(pythonProperty.DefaultValue);
                            sb.Append(Environment.NewLine);
                        }
                    }
                }

                // add each property
                foreach (object item in PropertiesList.Items)
                {
                    // write the setter
                    sb.Append(indent);                    
                    sb.Append("def Set");
                    sb.Append(item);
                    sb.Append("(self, ");
                    sb.Append(TextHelper.CapitalizeFirstChar(item.ToString(), true));
                    sb.Append("):");
                    sb.Append(Environment.NewLine);
                    sb.Append(indent2);
                    sb.Append("self.__");
                    sb.Append(item);
                    sb.Append(" = ");
                    sb.Append(TextHelper.CapitalizeFirstChar(item.ToString(), true));
                    sb.Append(Environment.NewLine);                    

                     // write the getter
                    sb.Append(indent);                    
                    sb.Append("def Get");
                    sb.Append(item);
                    sb.Append("(self):");
                    sb.Append(Environment.NewLine);
                    sb.Append(indent2);
                    sb.Append("return self.__");
                    sb.Append(item);
                    sb.Append(Environment.NewLine);
                }

                // now final thing is to write the properties
                foreach (object item in PropertiesList.Items)
                {
                    sb.Append(indent);
                    sb.Append(item);
                    sb.Append("=property(Get");
                    sb.Append(item);
                    sb.Append(", Set");
                    sb.Append(item);
                    sb.Append(")");
                    sb.Append(Environment.NewLine);
                }

                // get the class
                string result = sb.ToString().Trim();

                // Copy to the clipboard
                Clipboard.SetText(result);

                // Show a status label
                StatusLabel.Text = "Success! The class has been copied to your clipboard.";
            }
            #endregion
            
            #region DeleteButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'DeleteButton' is clicked.
            /// </summary>
            private void DeleteButton_Click(object sender, EventArgs e)
            {
                // Remove the selected item
                PropertiesList.Items.RemoveAt(PropertiesList.SelectedIndex);

                // erase
                PropertyNameTextBox.Text = "";

                // erase
                SelectedItem = null;
                
                // Back to read only
                EditMode = EditModeEnum.NotSet;
            }
            #endregion
            
            #region EditButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'EditButton' is clicked.
            /// </summary>
            private void EditButton_Click(object sender, EventArgs e)
            {
                // Set the EditMode
                EditMode = EditModeEnum.Edit;

                // Enable or disable controls
                UIEnable();

                // Set Focus
                PropertyNameTextBox.SetFocusToTextBox();
            }
            #endregion

            #region MainForm_Activated(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Main Form _ Activated
            /// </summary>
            private void MainForm_Activated(object sender, EventArgs e)
            {
                // if the value for StartupComplete is false
                if (!StartupComplete)
                {
                    // Set focus to the class name
                    ClassNameTextBox.SetFocusToTextBox();

                    // Set to true
                    StartupComplete = true;
                }
            }
            #endregion
            
            #region PropertiesList_SelectedIndexChanged(object sender, EventArgs e)
            /// <summary>
            /// event is fired when a selection is made in the 'PropertiesList_'.
            /// </summary>
            private void PropertiesList_SelectedIndexChanged(object sender, EventArgs e)
            {
                // Set the selected item
                SelectedItem = PropertiesList.SelectedItem as PythonProperty;

                // If the SelectedItem object exists
                if (NullHelper.Exists(SelectedItem))
                {
                    // Update the text
                    PropertyNameTextBox.Text = SelectedItem.PropertyName;

                    // Set the DefaultValue
                    DefaultValueTextBox.Text = SelectedItem.DefaultValue;
                }

                // Enable or disable controls
                UIEnable();
            }            
            #endregion
            
            #region SaveButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'SaveButton' is clicked.
            /// </summary>
            private void SaveButton_Click(object sender, EventArgs e)
            {
                // if the value for HasSelectedItem is true
                if (HasSelectedItem)
                {
                    // Capture values
                    SelectedItem.PropertyName = PropertyNameTextBox.Text;
                    SelectedItem.DefaultValue = DefaultValueTextBox.Text;

                    if (SelectedItem.IsValid())
                    {
                        if (EditMode == EditModeEnum.AddNew)
                        {
                            // Add this item
                            PropertiesList.Items.Add(SelectedItem);

                            // Show a message
                            StatusLabel.Text = "Property " + SelectedItem.PropertyName + " added.";
                        }
                        else
                        {
                            // Update
                            PropertiesList.Items[PropertiesList.SelectedIndex] = SelectedItem;

                            // Show a message
                            StatusLabel.Text = "Property " + SelectedItem.PropertyName + " updated.";
                        }
                    }
                    else
                    {
                        // Show a message
                        StatusLabel.Text = "You must enter the Property Name and the Default Value.";
                    }
                }

                // Back to read only
                EditMode = EditModeEnum.NotSet;

                // Enable controls
                UIEnable();
            }
            #endregion
            
        #endregion

        #region Methods
            
            #region UIEnable()
            /// <summary>
            /// UI Enable
            /// </summary>
            public void UIEnable()
            {
                // if in Edit Mode
                if ((EditMode == EditModeEnum.AddNew) || (EditMode == EditModeEnum.Edit))
                {
                    PropertyNameTextBox.Editable = true;
                    DefaultValueTextBox.Editable = true;
                    CancelSaveButton.Visible = true;
                    SaveButton.Visible = true;
                    CreateClassButton.Enabled = false;
                }
                else
                {
                    PropertyNameTextBox.Editable = false;
                    CancelSaveButton.Visible = false;
                    SaveButton.Visible = false;
                    DefaultValueTextBox.Editable = false;
                    CreateClassButton.Enabled = PropertiesList.Items.Count > 0;
                }
            }
            #endregion
            
        #endregion

        #region Properties

            #region EditMode
            /// <summary>
            /// This property gets or sets the value for 'EditMode'.
            /// </summary>
            public EditModeEnum EditMode
            {
                get { return editMode; }
                set { editMode = value; }
            }
            #endregion

            #region HasSelectedItem
            /// <summary>
            /// This property returns true if this object has a 'SelectedItem'.
            /// </summary>
            public bool HasSelectedItem
            {
                get
                {
                    // initial value
                    bool hasSelectedItem = (this.SelectedItem != null);
                    
                    // return value
                    return hasSelectedItem;
                }
            }
            #endregion
            
            #region SelectedItem
            /// <summary>
            /// This property gets or sets the value for 'SelectedItem'.
            /// </summary>
            public PythonProperty SelectedItem
            {
                get { return selectedItem; }
                set { selectedItem = value; }
            }
        #endregion

            #region StartupComplete
            /// <summary>
            /// This property gets or sets the value for 'StartupComplete'.
            /// </summary>
            public bool StartupComplete
            {
                get { return startupComplete; }
                set { startupComplete = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
