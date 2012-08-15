<%@ Page Language="C#" MasterPageFile="~/Default.master" Title="Untitled Page" %>

<%@ Register Assembly="NhsCui.Toolkit.Web" Namespace="NhsCui.Toolkit.Web" TagPrefix="NhsCui" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<NhsCui:TimeInputBox id="TimeInputBox" runat="server" AllowApproximate="false" Functionality="Simple" >
</NhsCui:TimeInputBox>

<script type="text/javascript" src="TimeTest.js"></script>
<script type="text/javascript">
var testHarness = null;
var testClass = NhsCui.Toolkit.Web.Tests.NhsTimeTest.prototype;

function proxyByCurrying(func) {
    return function() {
        try {
            func();
        } catch(e) {
            if(e.name==func.expectedException.name) {
                // OK. Received the expected exception
                return;
            } else {
                throw func.expectedException.message + ". Expected \"" + func.expectedException.name + "\", Received \"" + e + "\"";
            }
        }
        throw func.expectedException.message;
    }
}
function registerTests(harness) {
    testHarness = harness;
    
    for(var testMethod in testClass) {
        var test = testHarness.addTest(testMethod);
        
        // Is success of the test method predicated by throwing an exception?
        if(testClass[testMethod].expectedException) {
            // proxy the method by currying
            test.addStep(proxyByCurrying(testClass[testMethod]));
        } else {    
            test.addStep(testClass[testMethod]);
        }
    }
}

var Assert={};
Assert.AreEqual=function(expected, actual, message) {
    return testHarness.assertEqual(expected, actual, message);
}

Assert.IsTrue=function(condition, message) {
    return testHarness.assertTrue(condition, message);
}
    </script>

</asp:Content>

