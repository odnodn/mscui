//-----------------------------------------------------------------------
// <copyright file="MedicationNameTest.cs" company="Microsoft Corporation and Crown copyright 2007 - 2010.">
// Copyright (c) Microsoft Corporation and Crown copyright 2007 - 2010.
// All rights reserved.
//
// CERTAIN PARTS OF THIS WORK CONTAIN SOFTWARE CODE THAT IS LICENSED 
// FOR USE UNDER THE MICROSOFT PUBLIC LICENSE. DISTRIBUTION, IN SOURCE CODE 
// OR OBJECT CODE FORM, OF THOSE PARTS MUST COMPLY WITH THE TERMS OF THE 
// PUBLIC LICENSE. SEE http://www.microsoft.com/opensource/licenses.mspx 
// FOR DETAILS.  
// IF YOU BRING A PATENT CLAIM AGAINST ANY CONTRIBUTOR OVER PATENTS THAT 
// YOU CLAIM ARE INFRINGED BY THE PUBLIC LICENSE SOFTWARE, YOUR PATENT 
// LICENSE FROM SUCH CONTRIBUTOR TO THE SOFTWARE ENDS AUTOMATICALLY.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY 
// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
// </copyright>
// <date>02-Feb-2007</date>
// <summary>
// The following code was generated by Microsoft Visual Studio 2005.
// The test owner should check each test for validity.
// </summary>
//-----------------------------------------------------------------------
namespace NhsCui.Toolkit.Web.Test
{
    #region Using
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Threading;
    using NhsCui.Toolkit.Web;
    #endregion

    /// <summary>
    /// This is a test class for NhsCui.Toolkit.Web.MedicationName and is intended
    /// to contain all NhsCui.Toolkit.Web.MedicationName Unit Tests
    ///</summary>
    [TestClass()]
    public class MedicationNameTest : IDisposable
    {
        /// <summary>
        /// Text Context Instnace
        /// </summary>
        private TestContext testContextInstance;

        /// <summary>
        /// Reset event to indicate that the propertychanged event was raised
        /// </summary>
        private ManualResetEvent propertyChangedThreadEvent = new ManualResetEvent(false);

        /// <summary>
        /// Name of property reported by the property changed event
        /// </summary>
        private string changedPropertyName;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return this.testContextInstance;
            }

            set
            {
                this.testContextInstance = value;
            }
        }

        #region Additional test attributes
        // You can use the following additional attributes as you write your tests:        
        // Use ClassInitialize to run code before running the first test in the class        
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext)
        // {
        // }
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup()
        // {
        // }
        // Use TestInitialize to run code before running each test
        // [TestInitialize()]
        // public void MyTestInitialize()
        // {
        // }
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup()
        // {
        // }
        #endregion

        /// <summary>
        ///A test for DisplayLength
        ///</summary>
        [TestMethod()]
        public void DisplayLengthTest()
        {
            MedicationName target = new MedicationName();
            target.Name = "TestName";
            target.Information = "Information";

            int val = target.Name.Length + MedicationName.Separator.Length + target.Information.Length; // TODO: Assign to an appropriate value for the property

            Assert.AreEqual(val, target.DisplayLength, "NhsCui.Toolkit.Web.MedicationName.DisplayLength was not set correctly.");            
        }

        /// <summary>
        ///A test for DisplayLength
        ///</summary>
        [TestMethod()]
        public void DisplayLengthTest2()
        {
            MedicationName target = new MedicationName();
            target.Name = "TestName";

            int val = target.Name.Length;

            Assert.AreEqual(val, target.DisplayLength, "NhsCui.Toolkit.Web.MedicationName.DisplayLength was not set correctly.");
        }

        /// <summary>
        ///A test for Information
        ///</summary>
        [TestMethod()]
        public void InformationTest()
        {
            MedicationName target = new MedicationName();

            string val = "Info"; 

            target.Information = val;

            Assert.AreEqual(val, target.Information, "NhsCui.Toolkit.Web.MedicationName.Information was not set correctly.");            
        }

        /// <summary>
        ///A test for MedicationName (string, string)
        ///</summary>
        [TestMethod()]
        public void ConstructorTest()
        {
             string name = "AName"; // TODO: Initialize to an appropriate value

             string information = "AInfo"; // TODO: Initialize to an appropriate value

             MedicationName target = new MedicationName(name, information);

            // TODO: Implement code to verify target
             Assert.AreEqual(name, target.Name, "NhsCui.Toolkit.Web.MedicationName.Name was not set correctly.");
             Assert.AreEqual(information, target.Information, "NhsCui.Toolkit.Web.MedicationName.Information was not set correctly.");            
        }

        /// <summary>
        ///A test for Name
        ///</summary>
        [TestMethod()]
        public void NameTest()
        {
            MedicationName target = new MedicationName();

            string val = "AName"; // TODO: Assign to an appropriate value for the property

            target.Name = val;

            Assert.AreEqual(val, target.Name, "NhsCui.Toolkit.Web.MedicationName.Name was not set correctly.");            
        }

        /// <summary>
        ///A test for Name null
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "Expected ArgumentNull as Name cannot be null")]
        public void NameNullTest()
        {
            MedicationName target = new MedicationName();
            target.Name = null;            
        }

        /// <summary>
        ///A test for Name empty 
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "Expected ArgumentNull as Name cannot be empty")]
        public void NameEmptyTest()
        {
            MedicationName target = new MedicationName();
            target.Name = string.Empty;            
        }      

        /// <summary>
        ///A test for NotifyPropertyChanged (string)
        ///</summary>        
        [TestMethod()]
        public void NotifyPropertyChangedTestInformation()
        {            
            MedicationName target = new MedicationName();
            target.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(this.OnPropertyChanged);
            this.propertyChangedThreadEvent.Reset();
            string info = "NewInfo"; // TODO: Initialize to an appropriate value            
            target.Information = info;
            if (!this.propertyChangedThreadEvent.WaitOne(500, false))
            {
                Assert.Fail("Property Changed event was not raised for Information Property");
            }
            else
            {
                Assert.AreEqual<string>(this.changedPropertyName, "Information");
            }       
        }

        /// <summary>
        ///A test for NotifyPropertyChanged (string)
        ///</summary>        
        [TestMethod()]
        public void NotifyPropertyChangedTestName()
        {
            MedicationName target = new MedicationName();
            target.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(this.OnPropertyChanged);
            this.propertyChangedThreadEvent.Reset();
            string name = "NewInfo"; // TODO: Initialize to an appropriate value            
            target.Name = name;
            if (!this.propertyChangedThreadEvent.WaitOne(500, false))
            {
                Assert.Fail("Property Changed event was not raised for Name Property");
            }
            else
            {
                Assert.AreEqual<string>(this.changedPropertyName, "Name");
            }            
        }

        /// <summary>
        ///A test for ToString ()
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            MedicationName target = new MedicationName();

            string name = "TestName";
            string info = "TestInfo";

            target.Name = name;
            target.Information = info;
            string expected = name + MedicationName.Separator + info;
            string actual;

            actual = target.ToString();

            Assert.AreEqual(expected, actual, "NhsCui.Toolkit.Web.MedicationName.ToString did not return the expected value.");            
        }

        /// <summary>
        /// Ensure that the Change Event is cleaned up
        /// </summary>
        [TestCleanup()]        
        public void Cleanup()
        {
            this.propertyChangedThreadEvent.Close();
        }

        #region IDisposable Members
        /// <summary>
        /// Clean up Property Changed Event
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Dispose
        /// </summary>
        /// <param name="disposing">Dispose</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.propertyChangedThreadEvent != null)
                {
                    this.propertyChangedThreadEvent.Close();
                }
            }
        }
        #endregion

        /// <summary>
        /// Event Handler for Property Changed Event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Property Changed Event Args</param>
        private void OnPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            this.changedPropertyName = e.PropertyName;
            this.propertyChangedThreadEvent.Set();
        }
    }
}