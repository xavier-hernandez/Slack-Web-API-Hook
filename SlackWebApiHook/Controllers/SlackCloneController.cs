using Microsoft.AspNetCore.Mvc;
using Slack.Webhooks;

namespace SlackWebApiHook.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SlackCloneController : ControllerBase
    {
        [HttpPost]
        ///<Summary>
        /// http://localhost/SlackWebApiHook/SlackClone
        ///</Summary>
        public void Index(SlackMessage slackMessage)
        {
            string ping;
            string download;
            string upload;

            if (slackMessage.Attachments != null)
            {
                foreach (SlackAttachment slackAttachment in slackMessage.Attachments)
                {
                    if (slackAttachment.Fields != null)
                    {
                        foreach (SlackField slackField in slackAttachment.Fields)
                        {
                            switch (slackField.Title.ToUpper())
                            {
                                case "PING":
                                    ping = slackField.Value;
                                    break;
                                case "UPLOAD":
                                    upload = slackField.Value;
                                    break;
                                case "DOWNLOAD":
                                    download = slackField.Value;
                                    break;
                            }
                        }
                    }
                }
            }
        }


        [HttpPost]
        [Route("{name}")]
        ///<Summary>
        /// http://localhost/SlackWebApiHook/SlackClone/MyTest
        ///</Summary>
        public void Index(string name, SlackMessage slackMessage)
        {
            string ping;
            string download;
            string upload;

            if (slackMessage.Attachments != null)
            {
                foreach (SlackAttachment slackAttachment in slackMessage.Attachments)
                {
                    if (slackAttachment.Fields != null)
                    {
                        foreach (SlackField slackField in slackAttachment.Fields)
                        {
                            switch (slackField.Title.ToUpper())
                            {
                                case "PING":
                                    ping = slackField.Value;
                                    break;
                                case "UPLOAD":
                                    upload = slackField.Value;
                                    break;
                                case "DOWNLOAD":
                                    download = slackField.Value;
                                    break;
                            }
                        }
                    }
                }
            }
        }
    }
}
