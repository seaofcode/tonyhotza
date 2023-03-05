using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingCounter : BaseCounter
{
    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            // There is no Kitchen Object
            if (player.HasKitchenObject())
            {
                // Player is carrying item
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else
            {
                // player has nothing
            }
        }
        else
        {
            // There is a Kitchen Object
            if (player.HasKitchenObject())
            {
                // player is carrying something
            }
            else
            {
                // player is not carrying anything
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }
}
