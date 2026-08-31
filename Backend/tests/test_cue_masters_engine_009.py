"""
Automated Pytest Matrix #009 for Cue Masters
Validates shot force bounds, 8-ball score formulas, and AI coach debriefs.
"""
import pytest
from Backend.app.repositories.pool_match_repo_009 import PoolMatchRepository_009
from Backend.app.ai.nvidia_billiards_gateway_009 import NvidiaBilliardsGateway_009

def test_shot_packet_validation_009():
    repo = PoolMatchRepository_009()
    assert repo.validate_shot_packet(shot_force=42.0, spin_x=0.5, spin_y=-0.2) is True
    # Impossible shot force (120 > 65.0 max)
    assert repo.validate_shot_packet(shot_force=120.0, spin_x=0.0, spin_y=0.0) is False

def test_score_calculation_009():
    repo = PoolMatchRepository_009()
    # 7 balls * 50 + 200 = 550
    score = repo.calculate_match_points(balls_cleared=7, win_by_eight_ball=True)
    assert score == 550

def test_nvidia_billiards_gateway_009():
    gw = NvidiaBilliardsGateway_009()
    debrief = gw.generate_coach_debrief(player_score=450, accuracy_pct=91.5, scratches=0)
    assert debrief["rank"] == "CUE_MASTER"
    assert "positioning" in debrief["tactical_coach_tip"].lower()
