using Stratis.SmartContracts;

public struct VaultCertificateCreatedLog
{
    [Index] public Address Owner;
    public UInt256 Amount;
    public ulong VestedBlock;
}