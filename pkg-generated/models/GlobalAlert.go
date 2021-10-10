package bungieAPI

import "time"

type GlobalAlert struct {
	AlertKey       string           `json:"AlertKey"`
	AlertHtml      string           `json:"AlertHtml"`
	AlertTimestamp time.Time        `json:"AlertTimestamp"`
	AlertLink      string           `json:"AlertLink"`
	AlertLevel     GlobalAlertLevel `json:"AlertLevel"`
	AlertType      GlobalAlertType  `json:"AlertType"`
	StreamInfo     StreamInfo       `json:"StreamInfo"`
}
