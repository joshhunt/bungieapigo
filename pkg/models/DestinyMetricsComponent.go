package bungieapigo

type DestinyMetricsComponent struct {
	Metrics             map[int]DestinyMetricComponent `json:"metrics"`
	MetricsRootNodeHash int                            `json:"metricsRootNodeHash"`
}
