using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrisgame.Model
{
    internal class ScoreModel
    {
        public string NamePlayer { get; set; }
        public int Score { get; set; }
        public DateTime GameTime { get; set; }
        
        public ScoreModel()
        {

        }

    }
}
