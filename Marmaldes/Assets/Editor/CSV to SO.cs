using UnityEngine;
using UnityEditor;
using System.IO;

public class CSVtoSO
{
    private static string IngredientsPath = "/Editor/CSVs/Ingredients.csv";

    [MenuItem("Utilities/Generate Ingredients")]

    public static void GenerateIngredient()
    {

    string[] allLines = File.ReadAllLines(Application.dataPath + IngredientsPath);

    foreach (string s in allLines)
    {
    string[] splitData = s.Split(',');

    Ingredient ingredient = ScriptableObject.CreateInstance<Ingredient>();
    ingredient.ingredientName = splitData[0];
    ingredient.ingredientBuyCost = int.Parse(splitData[1]);
    ingredient.ingredientSellCost = int.Parse(splitData[2]);
    ingredient.ingredientMax = int.Parse(splitData[3]);

    AssetDatabase.CreateAsset(ingredient, $"Assets/Ingredient/{ingredient.ingredientName}.asset");
    } 

  AssetDatabase.SaveAssets();

    }

}                                                                                                                                                     
