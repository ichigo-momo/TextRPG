using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Attack:Action
    {
        public override void ActionPattern(Chara first, Chara second)
        {
            second.HP -= first.Attack;
        }
    }
}
