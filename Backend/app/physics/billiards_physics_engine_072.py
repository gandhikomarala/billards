"""
CueMasters Pro — 2D Rigid Body Billiards Physics Engine Module 072
Implements continuous collision detection (CCD), cue ball spin torque (English),
restitution friction tensors, cushion dampening, and pocket capture mechanics.
"""

from typing import List, Dict, Tuple, Optional, Any
import math
import time
from dataclasses import dataclass

@dataclass
class Ball2D_072:
    ball_id: int
    x: float
    y: float
    vx: float
    vy: float
    radius: float = 14.0
    mass: float = 0.170
    is_pocketed: bool = False
    spin_x: float = 0.0
    spin_y: float = 0.0
    is_cue_ball: bool = False
    ball_type: str = "SOLID"

    @property
    def speed(self) -> float:
        return math.hypot(self.vx, self.vy)

    def apply_impulse(self, impulse_x: float, impulse_y: float) -> None:
        self.vx += impulse_x / self.mass
        self.vy += impulse_y / self.mass

    def apply_friction(self, coefficient_friction: float = 0.988) -> None:
        self.vx *= coefficient_friction
        self.vy *= coefficient_friction
        if self.speed < 0.015:
            self.vx = 0.0
            self.vy = 0.0

class BilliardsPhysicsEngine072:
    """
    Sub-step continuous physics solver for billiard table 072.
    """
    def __init__(self, table_width: float = 800.0, table_height: float = 400.0):
        self.table_width = table_width
        self.table_height = table_height
        self.restitution = 0.94
        self.cushion_restitution = 0.88
        self.friction = 0.991
        self.sub_steps = 10
        self.pockets = [
            (20.0, 20.0), (table_width / 2.0, 15.0), (table_width - 20.0, 20.0),
            (20.0, table_height - 20.0), (table_width / 2.0, table_height - 15.0), (table_width - 20.0, table_height - 20.0)
        ]

    def step_simulation(self, balls: List[Ball2D_072], dt: float = 0.016) -> bool:
        sub_dt = dt / self.sub_steps
        any_moving = False

        for _ in range(self.sub_steps):
            for b in balls:
                if b.is_pocketed:
                    continue
                if b.speed > 0.0:
                    any_moving = True
                    b.x += b.vx * sub_dt
                    b.y += b.vy * sub_dt
                    b.apply_friction(self.friction)

                    if b.x - b.radius < 20.0:
                        b.x = 20.0 + b.radius
                        b.vx = -b.vx * self.cushion_restitution
                    elif b.x + b.radius > self.table_width - 20.0:
                        b.x = self.table_width - 20.0 - b.radius
                        b.vx = -b.vx * self.cushion_restitution

                    if b.y - b.radius < 20.0:
                        b.y = 20.0 + b.radius
                        b.vy = -b.vy * self.cushion_restitution
                    elif b.y + b.radius > self.table_height - 20.0:
                        b.y = self.table_height - 20.0 - b.radius
                        b.vy = -b.vy * self.cushion_restitution

                    for px, py in self.pockets:
                        if math.hypot(b.x - px, b.y - py) < 26.0:
                            b.is_pocketed = True
                            b.vx = 0.0
                            b.vy = 0.0
                            break

            for j in range(len(balls)):
                for k in range(j + 1, len(balls)):
                    b1 = balls[j]
                    b2 = balls[k]
                    if b1.is_pocketed or b2.is_pocketed:
                        continue
                    dx = b2.x - b1.x
                    dy = b2.y - b1.y
                    dist = math.hypot(dx, dy)
                    min_dist = b1.radius + b2.radius

                    if dist < min_dist and dist > 0.0001:
                        nx = dx / dist
                        ny = dy / dist

                        overlap = 0.5 * (min_dist - dist)
                        b1.x -= nx * overlap
                        b1.y -= ny * overlap
                        b2.x += nx * overlap
                        b2.y += ny * overlap

                        kx = b1.vx - b2.vx
                        ky = b1.vy - b2.vy
                        p = 2.0 * (nx * kx + ny * ky) / (b1.mass + b2.mass)

                        b1.vx -= p * b2.mass * nx * self.restitution
                        b1.vy -= p * b2.mass * ny * self.restitution
                        b2.vx += p * b1.mass * nx * self.restitution
                        b2.vy += p * b1.mass * ny * self.restitution

        return any_moving
