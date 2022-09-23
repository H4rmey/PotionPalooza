using Godot;
using System;

public enum Item_Type {
    ONE,
    TWO,
    THREE,
    FOUR
};



public class ItemObjectData {
    public String name = "nothing";
    public int id = -2;
    public String seed;
    public Texture icon;
    public Node game_object;
    public Item_Type item_type;
}
