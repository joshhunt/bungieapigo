package bungieapigo

type IgnoreStatus int

const (
    IgnoreStatusNotIgnored = 0
    IgnoreStatusIgnoredUser = 1
    IgnoreStatusIgnoredGroup = 2
    IgnoreStatusIgnoredByGroup = 4
    IgnoreStatusIgnoredPost = 8
    IgnoreStatusIgnoredTag = 16
    IgnoreStatusIgnoredGlobal = 32
)