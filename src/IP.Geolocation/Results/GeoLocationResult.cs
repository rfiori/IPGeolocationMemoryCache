﻿using IP.Geolocation.Interfaces;

namespace IP.Geolocation.Results;

public class GeoLocationResult : IIPGeolocationResult
{
	public string? Status { get; set; }
	public DateTime? LastQuery { get; set; }
	public string? Country { get; set; }
	public string? CountryCode { get; set; }
	public string? State { get; set; }
	public string? City { get; set; }
	public string? Zip { get; set; }
	public string? Latitude { get; set; }
	public string? Longitude { get; set; }
	public string? Timezone { get; set; }
	public string? ISP { get; set; }
	public string? Org { get; set; }
	public bool? Mobile { get; set; }
	public string? Others { get; set; }
}