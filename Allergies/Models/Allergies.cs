using System;
using System.Collections.Generic;

namespace Allergies.Models
{
  public class AllergenScore
  {
    public static Dictionary<string, int> allergenScores = new Dictionary<string, int>(){
      {"Eggs", 1},
      {"Peanuts", 2},
      {"Shellfish", 4},
      {"Strawberries", 8},
      {"Tomatoes", 16},
      {"Chocolate", 32},
      {"Pollen", 64},
      {"Cats", 128}
    };
    public AllergenScore()
    {
      TotalAllergyScore = 0;
    }
    public static int TotalAllergyScore { get; set; }
    public static int GetAllergyScore(string allergy)
    {
      if (allergenScores.ContainsKey(allergy))
      {
        return allergenScores[allergy];
      }
      return 0;
    }
    public static int CalculateTotalAllergyScore(string allergy)
    {
      if (allergenScores.ContainsKey(allergy))
      {
        int currentScore = allergenScores[allergy];
        TotalAllergyScore += currentScore;
        return currentScore;
      }
      return 0;
    }
  }
}


//allergen     score
//eggs         1
//peanuts      2
//shellfish    4
//strawberries 8
//tomatoes     16
//chocolate    32
//pollen       64
//cats         128