using MediaBrowser.Controller.Entities;
using MediaBrowser.Controller.Entities.Movies;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Entities;

namespace MediaBrowser.Providers.Plugins.Tmdb.BoxSets
{
    public class TmdbBoxSetExternalId : IExternalId
    {
        /// <inheritdoc />
        public string Name => TmdbUtils.ProviderName;

        /// <inheritdoc />
        public string Key => MetadataProvider.TmdbCollection.ToString();

        /// <inheritdoc />
        public string UrlFormatString => TmdbUtils.BaseTmdbUrl + "collection/{0}";

        /// <inheritdoc />
        public bool Supports(IHasProviderIds item)
        {
            return item is Movie || item is MusicVideo || item is Trailer;
        }
    }
}
