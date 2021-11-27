

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataJuggler.UltimateHelper;

#endregion

namespace PythonClassCreator
{

    #region class PythonProperty
    /// <summary>
    /// This class represents one property for a Python class
    /// </summary>
    public class PythonProperty
    {
        
        #region Private Variables
        private string propertyName;
        private string defaultValue;
        #endregion

        #region Methods

            #region IsValid()
            /// <summary>
            /// returns the Valid
            /// </summary>
            public bool IsValid()
            {
                // initial value
                bool isValid = TextHelper.Exists(PropertyName, DefaultValue);
                
                // return value
                return isValid;
            }
            #endregion
            
            #region ToString()
            /// <summary>
            /// method returns the String
            /// </summary>
            public override string ToString()
            {
                // return the name of this object
                return PropertyName;
            }
            #endregion
            
       #endregion

        #region Properties

            #region DefaultValue
            /// <summary>
            /// This property gets or sets the value for 'DefaultValue'.
            /// </summary>
            public string DefaultValue
            {
                get { return defaultValue; }
                set { defaultValue = value; }
            }
            #endregion
            
            #region PropertyName
            /// <summary>
            /// This property gets or sets the value for 'PropertyName'.
            /// </summary>
            public string PropertyName
            {
                get { return propertyName; }
                set { propertyName = value; }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
