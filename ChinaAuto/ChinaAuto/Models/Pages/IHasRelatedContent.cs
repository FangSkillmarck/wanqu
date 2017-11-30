using EPiServer.Core;

namespace ChinaAuto.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
