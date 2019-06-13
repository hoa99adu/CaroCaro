using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace game_Caro_deadline_31
{
    public class Player
    {
       
        #region initialize
        public Player(string name,Image mark, Image avt,int idPlayer)
        {
            this.Name = name;
            this.Mark = mark;
            this.Avt = avt;
            this.idPlayer = idPlayer;
          
        }

        #endregion
        #region properties
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private Image mark;

        public Image Mark
        {
            get { return mark; }
            set { mark = value; }
        }
        private Image avt;

        public Image Avt
        {
            get { return avt; }
            set { avt = value; }
        }
        private int idPlayer;

        public int IdPlayer
        {
            get { return idPlayer; }
            set { idPlayer = value; }
        }
        #endregion
        #region method
       
        #endregion
    }
}
