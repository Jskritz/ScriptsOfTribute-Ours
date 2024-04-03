﻿namespace ScriptsOfTribute.Board;

public enum GameEndReason
{
    INCORRECT_MOVE,
    PRESTIGE_OVER_40_NOT_MATCHED,
    PRESTIGE_OVER_80,
    PATRON_FAVOR,
    TURN_TIMEOUT,
    PATRON_SELECTION_TIMEOUT,
    PATRON_SELECTION_FAILURE,
    TURN_LIMIT_EXCEEDED,
    INTERNAL_ERROR,
    BOT_EXCEPTION,
    PREPARE_TIME_EXCEEDED,
}
