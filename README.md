# CUE MASTERS — Digital Mobile Billiards & Pool Platform

Cue Masters is an original digital implementation of competitive 8-ball and 9-ball billiards, featuring realistic ball-ball and cushion collisions, cue rotation aiming, adjustable power meters, spin mechanics, AI bot opponents, and distributed backend services.

---

## 🎱 Architecture Overview

```
CueMasters/
├── UnityClient/            # Unity C# Client Architecture
│   └── Assets/Scripts/     # Table, Balls, Cue, Physics, Rules, Scoring, AI, UI, Audio, Networking
├── Backend/                # Python FastAPI Distributed Backend Services
│   ├── app/                # API Endpoints, Models, Repositories, Analytics, NVIDIA Gateway
│   └── tests/              # Pytest automated test matrix (180 tests)
├── Infrastructure/         # Docker Compose, PostgreSQL configurations
├── docs/                   # Architecture, Game Design, Physics, Rules Engine, API & Deployment Specifications
├── scripts/                # Standalone demo runner & diagnostic probes
└── index.html              # Standalone Playable Web Edition
```

---

## 🚀 Quick Start

### 1. Run the Standalone Game Probe
```bash
python scripts/demo_run.py
```

### 2. Play the Billiards Game
Open `index.html` directly in your browser or serve with:
```bash
python -m http.server 8000
```

### 3. Run Backend Test Matrix
```bash
pytest Backend/tests/ -v
```
