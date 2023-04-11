using UnityEngine;

[CreateAssetMenu(fileName = "New Ingredient", menuName = "Ingredients/Ingredient")]
public class Ingredient : ScriptableObject
{
    public string ingredientName;
    public int ingredientBuyCost;
    public int ingredientSellCost;
    public int ingredientMax;
    public int ingredientSpoilRate;
    public int ingredientQuality;
    public int ingredientGridSize;

}