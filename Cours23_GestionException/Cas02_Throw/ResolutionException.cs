
namespace Cas02_
{
    [Serializable]
    internal class ResolutionException : Exception //hérute de la classe exception par défaut
    {
        public ResolutionException(): base("le discriminant est négatif, il n'y a pas de solution réelle")
        {
        }

        public ResolutionException(string? message) : base(message)
        {
        }

        public ResolutionException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}