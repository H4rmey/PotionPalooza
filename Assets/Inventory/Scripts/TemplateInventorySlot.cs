using Godot;
using System;

public class TemplateInventorySlot : TextureButton {

    ItemObjectData item_object_data = new ItemObjectData();
    TextureRect icon; 
    
    public override void _Ready() {
        icon = this.GetChild(0) as TextureRect;

        initializeItemObjectData();
    }

    public override void _Process(float delta) {
        base._Process(delta);

        if (item_object_data.icon != null) {
            icon.Texture = item_object_data.icon;
        }
    }

    private void initializeItemObjectData() {
        item_object_data.id = -1; 
        item_object_data.name = "uninitialized name"; 
        item_object_data.item_type = Item_Type.ONE;
    }
}

