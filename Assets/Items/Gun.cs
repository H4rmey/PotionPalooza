using Godot;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class Gun_Params_Limits {
    public int[] projectile_size_x;
    public int[] projectile_accuracy_x;
    public int[] gun_handling_x;
    public int[] projectile_size_y;
    public int[] projectile_accuracy_y;
    public int[] gun_handling_y;

    public int[] projectile_speed;
    public int[] projectile_amount;
    public int[] projectile_storage;
    public int[] projectile_rate;
    public int[] projectile_damage;
    public int[] projectile_reflect;
    public int[] projectile_range;
    public int[] projectile_shape;
    public int[] projectile_crit_multiplier;
    public int[] projectile_crit_chance;
    public int[] reload_time;
}

public struct Gun_Params 
{
    public Vector2 projectile_size;
    public Vector2 projectile_accuracy;
    public Vector2 gun_handling;

    public int projectile_speed;
    public int projectile_amount;
    public int projectile_storage;
    public int projectile_rate;
    public int projectile_damage;
    public int projectile_reflect;
    public int projectile_range;
    public int projectile_shape;
    public int projectile_crit_multiplier;
    public int projectile_crit_chance;
    public int reload_time;
}

public class Gun : Node 
{
    int mod_count;

    GunManu manu;
    GunType type;

    List<ModTrait>  traits;
    List<Mod>       mods;

    public override void _Ready() 
    {
        string path = "res://Assets/configs/gun_manufacturers.json";
        var file = new File();
        file.Open(path, File.ModeFlags.Read);
        string json = file.GetAsText();
        file.Close();

        JObject obj = JObject.Parse(json);
        string check = obj["manufacturer1"]["gun_flags"].ToString(Formatting.None);
        
        Gun_Params_Limits gpl = JsonConvert.DeserializeObject<Gun_Params_Limits>(check);
    }
}