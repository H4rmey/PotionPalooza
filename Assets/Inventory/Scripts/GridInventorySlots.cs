using Godot;
using System;

public class GridInventorySlots : GridContainer {

    [Export]
    public Vector2 grid_size = new Vector2(4, 80);

    [Export]
    public Vector2 cell_size = new Vector2(52, 52);

    [Export]
    public Vector2 cell_spacing = new Vector2(10, 10);

    public override void _Ready() {
        base._Ready();        

        this.Columns = (int)grid_size.x;
        this.AddConstantOverride("hseparation", (int)cell_spacing.x);
        this.AddConstantOverride("vseparation", (int)cell_spacing.y); 

        int size = (int)grid_size.x * (int)grid_size.y;
        for (int i = 0; i < size; i++) {
            PackedScene template_slot = ResourceLoader.Load("res://Assets/Inventory/Templates/TemplateInventorySlot.tscn") as PackedScene;
            TextureButton texture_button = template_slot.Instance<TextureButton>();
            TemplateInventorySlot inventory_slot = template_slot.Instance<TemplateInventorySlot>();

            texture_button.RectSize = cell_size;
            texture_button.RectMinSize = cell_size;

            texture_button.Name = "slot_" + i;
            inventory_slot.Name = "slot_" + i;
            this.AddChild(texture_button, true);
        }
    }
}
