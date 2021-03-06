namespace Sustainsys.Saml2.Metadata.Tokens
{
    public abstract class SecurityKey
    {
        public abstract int KeySize { get; }

        public abstract byte[] DecryptKey(string algorithm, byte[] keyData);

        public abstract byte[] EncryptKey(string algorithm, byte[] keyData);

        public abstract bool IsAsymmetricAlgorithm(string algorithm);

        public abstract bool IsSupportedAlgorithm(string algorithm);

        public abstract bool IsSymmetricAlgorithm(string algorithm);
    }
}