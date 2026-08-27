-- Build: c92a4d4dc6b0ce6625bdc2feb3a90bea
local M = {}

function M.clamp(value, minimum, maximum)
  return math.max(minimum, math.min(maximum, value))
end

return M
