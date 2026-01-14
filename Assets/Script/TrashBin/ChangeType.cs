using UnityEngine;

public class ChangeType
{
    private TrashBinData data = TrashBinData.getInstance();

    public void changeToFoodWaste()
    {
        data.FoodWaste = true;
        data.PaperWaste = false;
        data.PlasticWaste = false;
        data.MetalWaste = false;
    }

    public void changeToPaperWaste()
    {
        data.FoodWaste = false;
        data.PaperWaste = true;
        data.PlasticWaste = false;
        data.MetalWaste = false;
    }

    public void changeToPlasticWaste()
    {
        data.FoodWaste = false;
        data.PaperWaste = false;
        data.PlasticWaste = true;
        data.MetalWaste = false;
    }

    public void changeToMetalWaste()
    {
        data.FoodWaste = false;
        data.PaperWaste = false;
        data.PlasticWaste = false;
        data.MetalWaste = true;
    }
}
