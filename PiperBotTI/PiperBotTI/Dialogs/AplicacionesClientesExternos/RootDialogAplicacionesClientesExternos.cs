using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Schema;
using System.ComponentModel;

namespace PiperBotTI.Dialogs.AplicacionesClientesExternos
{
    public class RootDialogAplicacionesClientesExternos : ComponentDialog
    {
        public static Activity ICrearTicketBloqueoBitLocker()
        {
            var videoCard = new Attachment();
            videoCard.Name = "Accesos";
            videoCard.ContentType = "video/mp4";
            videoCard.ContentUrl = "https://piperbotstorage.blob.core.windows.net/videos/Accesos.mp4";

            var reply = MessageFactory.Attachment(videoCard);
            return reply as Activity;
        }
        public static Activity ICrearTicketBloqueoContraseña()
        {
            var videoCard = new Attachment();
            videoCard.Name = "Accesos";
            videoCard.ContentType = "video/mp4";
            videoCard.ContentUrl = "https://piperbotstorage.blob.core.windows.net/videos/Accesos.mp4";

            var reply = MessageFactory.Attachment(videoCard);
            return reply as Activity;
        }
        public static Activity ICrearTicketCuentaPrivilegiada()
        {
            var videoCard = new Attachment();
            videoCard.Name = "Accesos";
            videoCard.ContentType = "video/mp4";
            videoCard.ContentUrl = "https://piperbotstorage.blob.core.windows.net/videos/Accesos.mp4";

            var reply = MessageFactory.Attachment(videoCard);
            return reply as Activity;
        }
        public static Activity ICrearTicketListaDeDistribucionVerificacion()
        {
            var videoCard = new Attachment();
            videoCard.Name = "Accesos";
            videoCard.ContentType = "video/mp4";
            videoCard.ContentUrl = "https://piperbotstorage.blob.core.windows.net/videos/Accesos.mp4";

            var reply = MessageFactory.Attachment(videoCard);
            return reply as Activity;
        }

    }
}
