/*
Terminal Game - Create Hero Class
In this first kata in the series, you need to define a Hero class to be used in a terminal game. The hero should have the following attributes:

attribute type	value
Name	string	user argument or "Hero"
Position	string	"00"
Health	float	100
Damage	float	5
Experience	int	0
    
*/

public class Hero
{
    private string name;
    private string position;
    private float health;
    private float damage;
    private int experience;

    public Hero()
    {
        this.name = "Hero";
        this.position = "00";
        this.health = 100.0f;
        this.damage = 5.0f;
        this.experience = 0;
    }
    public Hero(string name)
    {
        this.name = name ;
        this.position = "00";
        this.health = 100.0f;
        this.damage = 5.0f;
        this.experience = 0;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public string Position
    {
        get { return this.position; }
        set { this.position = value; }
    }

    public float Health
    {
        get { return this.health; }
        set { this.health = value; }
    }

    public float Damage
    {
        get { return this.damage; }
        set { this.damage = value; }
    }

    public int Experience
    {
        get { return this.experience; }
        set { this.experience = value; }
    }
}