using System.Diagnostics;

namespace MiddleWeir.Midleware
{
	public class RequesTimingMiddleware
	{
		private readonly RequestDelegate _next;
		public RequesTimingMiddleware(RequestDelegate next)
		{
		_next = next;
		}

		public async Task InvokeAsync(HttpContext context)
		{
			var whatch = Stopwatch.StartNew();

			await _next(context);

			whatch.Stop();

			var elapsed = whatch.ElapsedMilliseconds;

			Debug.WriteLine($"istek yolu: {context.Request.Path} işlem süresi: {elapsed} ");
		}
	}
}
