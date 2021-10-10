package bungieapigo

type ItemBindStatus int

const (
    ItemBindStatusNotBound = 0
    ItemBindStatusBoundToCharacter = 1
    ItemBindStatusBoundToAccount = 2
    ItemBindStatusBoundToGuild = 3
)