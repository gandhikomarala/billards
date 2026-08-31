"""
Automated Pytest Matrix #018 for Cue Masters
Validates shot force bounds, 8-ball score formulas, and AI coach debriefs.
"""
import pytest
from Backend.app.repositories.pool_match_repo_018 import PoolMatchRepository_018
from Backend.app.ai.nvidia_billiards_gateway_018 import NvidiaBilliardsGateway_018

def test_shot_packet_validation_018():
    repo = PoolMatchRepository_018()
    assert repo.validate_shot_packet(shot_force=42.0, spin_x=0.5, spin_y=-0.2) is True
    # Impossible shot force (120 > 65.0 max)
    assert repo.validate_shot_packet(shot_force=120.0, spin_x=0.0, spin_y=0.0) is False

def test_score_calculation_018():
    repo = PoolMatchRepository_018()
    # 7 balls * 50 + 200 = 550
    score = repo.calculate_match_points(balls_cleared=7, win_by_eight_ball=True)
    assert score == 550

def test_nvidia_billiards_gateway_018():
    gw = NvidiaBilliardsGateway_018()
    debrief = gw.generate_coach_debrief(player_score=450, accuracy_pct=91.5, scratches=0)
    assert debrief["rank"] == "CUE_MASTER"
    assert "positioning" in debrief["tactical_coach_tip"].lower()
