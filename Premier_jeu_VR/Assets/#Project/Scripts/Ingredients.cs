using UnityEngine;

public class Ingredients : MonoBehaviour
{
    public enum IngredientType
    {
        MushroomRed,
        MushroomGreen,
        MushroomBlue,
        MushroomBrown,
        Daisy,
        RedRose,
        BlackRose,
        Sunflower,
        Brain,
        Stomach,
        Claw,
        Diaphragm,
        Lung,
        NightmareBeetle,
        Spider,
        Apple,
        Broccoli,
        Carrot,
        Cheese,
        ChickenChest,
        ChickenBreast,
        Egg,
        Meet,
        Potato,
        Steak,
        Tomato
    };

    public IngredientType type;
    private int score;

    void Start()
    {
        score = GetScoreByType(type);
    }

    private int GetScoreByType(IngredientType it)
    {
        switch (it)
        {
            case IngredientType.MushroomRed: return +13;
            case IngredientType.MushroomGreen: return +27;
            case IngredientType.MushroomBlue: return +16;
            case IngredientType.MushroomBrown: return +16;
            case IngredientType.Daisy: return +16;
            case IngredientType.RedRose: return +16;
            case IngredientType.BlackRose: return +16;
            case IngredientType.Sunflower: return +16;
            case IngredientType.Brain: return +16;
            case IngredientType.Stomach: return +16;
            case IngredientType.Claw: return +16;
            case IngredientType.Diaphragm: return +16;
            case IngredientType.Lung: return +16;
            case IngredientType.NightmareBeetle: return +16;
            case IngredientType.Spider: return +16;
            case IngredientType.Apple: return +16;
            case IngredientType.Broccoli: return +16;
            case IngredientType.Carrot: return +16;
            case IngredientType.Cheese: return +16;
            case IngredientType.ChickenChest: return +16;
            case IngredientType.ChickenBreast: return +16;
            case IngredientType.Egg: return +16;
            case IngredientType.Meet: return +16;
            case IngredientType.Potato: return +16;
            case IngredientType.Steak: return +16;
            case IngredientType.Tomato: return +16;
            default: return 0;
        }
    }

    void Update()
    {
        
    }
}
