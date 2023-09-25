using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergies.Models;

namespace Allergies.Tests
{
  [TestClass]
  public class AllergiesTests
  {
    [TestMethod]
    public void AllergenScore_ReturnsValueOfReferencedAllergen_Int()
    {
    int allergyScore = AllergenScore.allergenScores["Eggs"];
    Assert.AreEqual(1, allergyScore);
    }
  }
}