using System;
using System.Collections.Generic;

namespace Allergies.Models
{
  public class AllergenScore
  {
    Dictionary<string, int> AllergenScores = new Dictionary<string, int>(){
      {"Eggs", 1},
      {"Peanuts", 2},
      {"Shellfish", 4},
      {"Strawberries", 8},
      {"Tomatoes", 16},
      {"Chocolate", 32},
      {"Pollen", 64},
      {"Cats", 128}
    };
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