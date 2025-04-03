[task: Curiosity.Tasks.Name("Custom Code Scheduled Task 2")]
[task: Curiosity.Tasks.UID("gFNYyeKvGatEdG9W1zToab")]
[task: Curiosity.Tasks.Schedule("0 1 * * *")]

Logger.LogInformation("Task run at: {0:u}", DateTimeOffset.UtcNow);
