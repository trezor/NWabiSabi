namespace WabiSabi.CredentialRequesting;

using Crypto;
using Crypto.ZeroKnowledge;
using Newtonsoft.Json;

/// <summary>
/// Represents a response message for the WabiSabi unified registration protocol.
/// </summary>
/// <remarks>
/// RegistrationResponseMessage message is the unified protocol message used in both phases,
/// inputs registration and outputs registration. It contains the collection of `k` issued
/// credentials and the corresponding proofs.
/// </remarks>
public class CredentialsResponse
{
	[JsonConstructor]
	public CredentialsResponse(IEnumerable<MAC> issuedCredentials, IEnumerable<Proof> proofs)
	{
		IssuedCredentials = issuedCredentials;
		Proofs = proofs;
	}

	/// <summary>
	/// Credentials issued by the coordinator.
	/// </summary>
	public IEnumerable<MAC> IssuedCredentials { get; }

	/// <summary>
	/// Proofs that the credentials were issued using the coordinator's secret key.
	/// </summary>
	public IEnumerable<Proof> Proofs { get; }
}
