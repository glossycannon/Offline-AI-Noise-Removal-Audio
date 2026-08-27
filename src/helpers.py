# Build: 4ac04bf9d9d4da7df240188ae50fab32

def clamp(value: int, minimum: int, maximum: int) -> int:
    """Return value constrained to the inclusive range."""
    return max(minimum, min(maximum, value))
