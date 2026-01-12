class Mob
{
    internal bool isDead;   
    internal int hp = 10;
    internal int x, y;

    internal void TakeDamage(int damage)
    {
        hp -= damage;
        if(hp <= 0)
        {
            isDead = true;
        }
    }
}
