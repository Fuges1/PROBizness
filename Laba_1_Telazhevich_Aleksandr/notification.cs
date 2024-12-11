using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulpep.NotificationWindow;

namespace PROBizness
{


    internal class notification
    {
        private PopupNotifier conectSQL = null;
        private PopupNotifier connctSQL2 = null;
        private PopupNotifier connctSQL3 = null;
        private PopupNotifier connctSQL4 = null;
        public void conNO()
        {
            conectSQL = new PopupNotifier();


            conectSQL.Image = Properties.Resources.net;

            conectSQL.ImageSize = new Size(96, 96);

            conectSQL.TitleColor = Color.Azure;

            conectSQL.TitleText = "Соедиенение с Базой данных (SQL)";

            conectSQL.ContentText = "Не удалось связаться с БД =(";

            conectSQL.ShowCloseButton = false;

            conectSQL.Popup();
        }
        public void conYes()
        {
            connctSQL2 = new PopupNotifier();

            connctSQL2.Image = Properties.Resources.Ok;

            connctSQL2.ImageSize = new Size(96, 96);

            connctSQL2.TitleColor = Color.Azure;

            connctSQL2.TitleText = "Соедиенение с Базой данных (SQL)";

            connctSQL2.ContentText = "Соедиенение с БД установленно!!";

            connctSQL2.ShowCloseButton = false;

            connctSQL2.Popup();
        }
        public void AddTabl()
        {
            connctSQL3 = new PopupNotifier();

            connctSQL3.Image = Properties.Resources.Ok;

            connctSQL3.ImageSize = new Size(96, 96);

            connctSQL3.TitleColor = Color.Azure;

            connctSQL3.TitleText = "Редактирование БД";

            connctSQL3.ContentText = "Таблица добавленна успешно";

            connctSQL3.ShowCloseButton = false;

            // connctSQL3.Popup();
        }
        public void DelTable()
        {
            connctSQL4 = new PopupNotifier();

            connctSQL4.Image = Properties.Resources.Ok;

            connctSQL4.ImageSize = new Size(96, 96);

            connctSQL4.TitleColor = Color.Azure;

            connctSQL4.TitleText = "Редактирование БД";

            connctSQL4.ContentText = "Удаление таблицы успешно";

            connctSQL4.ShowCloseButton = false;

            // connctSQL4.Popup();
        }
    }
}
