using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Schema;
using PiperBotTI.Contracts;
using PiperBotTI.Dialogs.Qualification;
using System;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;

namespace PiperBotTI.Dialogs.Accesos
{
    public class RootDialogAccesos : ComponentDialog
    {
        private async Task<DialogTurnResult> ManageIntentions(WaterfallStepContext stepContext, RecognizerResult luisResult, CancellationToken cancellationToken)
        {
            var topIntent = luisResult.GetTopScoringIntent();
              switch (topIntent.intent)
              {
                case "CrearTicketBloqueoBitLocker":
                    await ICrearTicketBloqueoBitLocker(stepContext, luisResult, cancellationToken);
                    break;
                case "CrearTicketBloqueoContraseña":
                    await ICrearTicketBloqueoContraseña(stepContext, luisResult, cancellationToken);
                    break;
                case "CrearTicketCuentaPrivilegiada":
                    await ICrearTicketCuentaPrivilegiada(stepContext, luisResult, cancellationToken);
                    break;
                case "CrearTicketListaDeDistribucionVerificacion":
                    await ICrearTicketListaDeDistribucionVerificacion(stepContext, luisResult, cancellationToken);
                    break;
                default:
                    await stepContext.Context.SendActivityAsync(MessageFactory.Text("No entendí lo que quisiste decir, intenta de nuevo."), cancellationToken);
                    break;
              }
            return await stepContext.NextAsync(cancellationToken);
        }

        private async Task<DialogTurnResult> ICrearTicketListaDeDistribucionVerificacion(WaterfallStepContext stepContext, RecognizerResult luisResult, CancellationToken cancellationToken)
        {
            return await stepContext.BeginDialogAsync(nameof(AccesosDialog), cancellationToken:cancellationToken);
        }

        private async Task<DialogTurnResult>ICrearTicketCuentaPrivilegiada(WaterfallStepContext stepContext, RecognizerResult luisResult, CancellationToken cancellationToken)
        {
            return await stepContext.BeginDialogAsync(nameof(AccesosDialog),cancellationToken:cancellationToken);
        }

        private async Task<DialogTurnResult>ICrearTicketBloqueoContraseña(WaterfallStepContext stepContext, RecognizerResult luisResult, CancellationToken cancellationToken)
        {
            return await stepContext.BeginDialogAsync(nameof(AccesosDialog),cancellationToken:cancellationToken);
        }

        private async Task<DialogTurnResult>ICrearTicketBloqueoBitLocker(WaterfallStepContext stepContext, RecognizerResult luisResult, CancellationToken cancellationToken)
        {
            return await stepContext.BeginDialogAsync(nameof(AccesosDialog),cancellationToken:cancellationToken);
        }
    }
}
