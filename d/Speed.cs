using System;

namespace Provet
{
    public class Speed : MC
    {
        public int strength = 20;
        public void SetStrength(int newStrength)
        {
            strength = newStrength;
        }
        public int GetHp(){
            return hp;
        }
    }
}
