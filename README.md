**Slack Incoming Webhook Clone**

I was having a hard time finding code to read in a webhook meant for Slack. So here you go.

I'm using Speetest-Tracker, https://github.com/henrywhitaker3/Speedtest-Tracker, and it only supports Slack webhook or Telegram. I already have a .net core API so I just wanted to integrate Speetest-Tracker with that.

The project uses NuGet package Slack.WebHooks which already has all the classes you need. 

I basically created 2 endpoints that accept a SlackMessage via HttpPost.

