using System.Collections;

using NUnit.Framework;
using UnityEditor;
using UnityEngine;
using UnityEngine.TestTools;

[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "GTFO")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1634:FileHeaderMustShowCopyright", Justification = "GTFO")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1604:ElementDocumentationMustHaveSummary", Justification = "GTFO")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1615:ElementReturnValueMustBeDocumented", Justification = "GTFO")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1611:ElementParametersMustBeDocumented", Justification = "GTFO")]

/// NewEditModeTest
public class NewEditModeTest
{
    /// NewEditModeTestSimplePasses.
    [Test]
    public void NewEditModeTestSimplePasses()
    {
        // Use the Assert class to test conditions.
    }

    [Test]
    public void NewTestFoo()
    {
        Assert.That(2 + 2 == 5);
    }

    /// NewEditModeTestWithEnumeratorPasses
    /// A UnityTest behaves like a coroutine in PlayMode
    /// and allows you to yield null to skip a frame in EditMode
    [UnityTest]
    public IEnumerator NewEditModeTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // yield to skip a frame
        yield return null;
    }
}
