namespace ServiceLib.Models.Entities;

public record TransportExtraItem
{
    public string? RawHeaderType { get; init; }

    public string? Host { get; init; }
    public string? Path { get; init; }
    public string? XhttpMode { get; init; }
    public string? XhttpExtra { get; init; }

    public string? GrpcAuthority { get; init; }
    public string? GrpcServiceName { get; init; }
    public string? GrpcMode { get; init; }

    public int? KcpMtu { get; init; }
    public int? KcpTti { get; init; }
    public int? KcpUplinkCapacity { get; init; }
    public int? KcpDownlinkCapacity { get; init; }
    public bool? KcpCongestion { get; init; }
    public int? KcpReadBufferSize { get; init; }
    public int? KcpWriteBufferSize { get; init; }
}
