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
    int allergyScore2 = AllergenScore.allergenScores["Cats"];
    Assert.AreEqual(1, allergyScore);
    Assert.AreEqual(128, allergyScore2);
    }
    [TestMethod]
    public void GetAllergyScore_ReturnsValueOfReferencedAllergenInput_Int()
    {
      int allergyScore = AllergenScore.GetAllergyScore("Eggs");
      int allergyScore2 = AllergenScore.GetAllergyScore("Cats");
      Assert.AreEqual(1, allergyScore);
      Assert.AreEqual(128, allergyScore2);
    }
  }
}