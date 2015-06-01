﻿namespace TwitterSystem.Web.ViewModels.Alerts
{
    using System;

    public class AlertViewModel
    {
        public AlertViewModel(string message, AlertType type    )
        {
            this.Message = message;
            this.Type = type;
        }

        public AlertType Type { get; set; }

        public string Message { get; set; }

        public string getCssStyle
        {
            get
            {
                switch (this.Type)
                {
                    case AlertType.Info:
                        return "info";
                    case AlertType.Error:
                        return "danger";
                    case AlertType.Success:
                        return "success";
                    default:
                        throw new NotSupportedException();
                }
            }
        }
    }
}