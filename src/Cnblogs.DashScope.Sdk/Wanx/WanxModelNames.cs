﻿using Cnblogs.DashScope.Sdk.Internals;

namespace Cnblogs.DashScope.Sdk.Wanx;

internal static class WanxModelNames
{
    public static string GetModelName(this WanxModel model)
    {
        return model switch
        {
            WanxModel.WanxV1 => "wanx-v1",
            _ => ThrowHelper.UnknownModelName(nameof(model), model)
        };
    }

    public static string GetModelName(this WanxStyleRepaintModel model)
    {
        return model switch
        {
            WanxStyleRepaintModel.WanxStyleRepaintingV1 => "wanx-style-repaint-v1",
            _ => ThrowHelper.UnknownModelName(nameof(model), model)
        };
    }
}
