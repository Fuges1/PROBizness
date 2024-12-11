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
        private PopupNotifier AddTable = null;
        private PopupNotifier Deltable = null;
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
            AddTable = new PopupNotifier();

            AddTable.Image = Properties.Resources.Ok;

            AddTable.ImageSize = new Size(96, 96);

            AddTable.TitleColor = Color.Azure;

            AddTable.TitleText = "Редактирование БД";

            AddTable.ContentText = "Таблица добавленна успешно";

            AddTable.ShowCloseButton = false;

            AddTable.Popup();
        }
        public void DelTable()
        {
            Deltable = new PopupNotifier();

            Deltable.Image = Properties.Resources.Ok;

            Deltable.ImageSize = new Size(96, 96);

            Deltable.TitleColor = Color.Azure;

            Deltable.TitleText = "Редактирование БД";

            Deltable.ContentText = "Удаление таблицы успешно";

            Deltable.ShowCloseButton = false;

            Deltable.Popup();
        }
    }
}
