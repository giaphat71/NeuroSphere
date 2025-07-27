### Invention: Spatially Addressed Resonant Nanoparticle (SARNA) Stimulation

#### The Guiding Principle: The Radio Tuner Analogy

Think of every radio station in a city. They all broadcast at the same time, filling the air with electromagnetic waves. Your car radio doesn't get overwhelmed; you simply **tune your receiver** to a specific frequency (e.g., 94.5 MHz) to listen to one station while ignoring all others.

The SARNA method applies this exact principle to neurons. We will make each optic nerve fiber its own unique "radio station" that only "listens" for its specific frequency.

### The Three Core Components

#### 1. The Nanoparticle Resonators (The "Radio Receivers")

This is the key invention. We will fabricate a vast library of biocompatible nanoparticles, each designed to be a passive electronic resonator.

- **Structure:** These would be core-shell nanoparticles, approximately 50-100 nanometers in size.
  - **The Core:** A material with a high dielectric constant or specific conductive properties.
  - **The Shell:** A biocompatible, insulating layer (e.g., a silica or polymer coating) with a precisely controlled thickness.
- **The Physics:** This structure forms a nanoscale **LC circuit** or, more accurately, a **plasmonic resonator**. It has a natural, sharp resonant frequency determined by its exact size, shape, and material composition. When an external EM field matching this frequency hits the nanoparticle, it absorbs energy dramatically. At all other frequencies, it is effectively invisible.
- **The "Library":** Using advanced nanofabrication, we can create millions of batches of these nanoparticles. The nanoparticles in "Batch A" might resonate at 1.000 GHz, "Batch B" at 1.001 GHz, "Batch C" at 1.002 GHz, and so on. We can create a library with a million unique "channels."

#### 2. The Delivery and Binding System (The "Installation")

We need to get one unique nanoparticle attached to each of the ~1 million axons in the optic nerve. This is a biological challenge, not a physics one.

- **Method:** A modified, non-replicating adeno-associated virus (AAV) is used as the delivery vehicle. The virus is engineered to express a "tether" protein on the surface of the axon's membrane.
- **Stochastic Labeling:** It is impossible to assign nanoparticle #1 to axon #1, #2 to #2, etc. Instead, we inject the entire library of a million unique nanoparticle types. They will bind randomly to the tethered axons. Axon #583,401 might get a nanoparticle that resonates at 1.345 GHz, while its neighbor axon #583,402 gets one that resonates at 1.872 GHz. The map is random, but it is **stable**.

#### 3. The External EM Emitter (The "Broadcast Tower")

This is a device worn like a pair of glasses or a helmet.

- **Method:** It contains a **phased-array RF emitter**. It does not need to focus the energy to a micrometer point. It only needs to bathe the entire optic nerve region in a low-power, multi-frequency electromagnetic field.
- **The Physics:** It uses a technique called **Orthogonal Frequency-Division Multiplexing (OFDM)**, the same technology that powers modern Wi-Fi and 4G/5G. This allows it to broadcast thousands of different, non-interfering frequency signals simultaneously.

### The Four-Step Method of Operation

1. **Fabrication & Delivery:** The nanoparticle library is fabricated. The patient receives a one-time injection of the AAV vector and then the nanoparticle library, which self-assembles and binds to the optic nerve fibers.
2. **Mapping & Learning (The Critical Step):** The system must now learn the random map. This is a closed-loop process.
    - The external emitter sends a pulse at a single frequency, e.g., **1.345 GHz**.
    - One specific nanoparticle on one specific axon resonates. This resonance creates a localized, oscillating electric field powerful enough to depolarize the axon's membrane and trigger an action potential (a nerve signal).
    - The user experiences a flash of light (a phosphene) in a specific location in their field of view (e.g., "upper right corner").
    - The user indicates where they saw the light via a joystick or eye-tracker.
    - The system's computer logs: **Frequency 1.345 GHz = Phosphene at (X, Y) coordinate**.
    - This process is repeated thousands of times until a comprehensive "frequency-to-location" map is built.
3. **Real-Time Operation:**
    - A camera on the user's glasses captures an image.
    - A processor on the glasses converts the image into a simplified, high-contrast map of "phosphene points."
    - The processor sees it needs to create a point of light in the "upper right corner." It looks up its map and finds that this corresponds to frequency 1.345 GHz.
    - The emitter broadcasts the 1.345 GHz signal. The correct axon fires, and the user perceives a point of light in the intended location.
4. **Creating an Image:** By broadcasting hundreds or thousands of different frequencies simultaneously using OFDM, the system can activate hundreds of axons in parallel, "drawing" a coherent shape made of many phosphene points in the user's mind.

### Summary of Physics Used

- **Electromagnetic Resonance:** The core principle for addressing individual nanoparticles.
- **Plasmonics / Nanophotonics:** The physics governing how nanoparticles interact with EM fields.
- **Voltage-Gated Ion Channel Physics:** The mechanism by which the nanoparticle's local field triggers the neuron to fire.
- **Phased-Array Emitters & OFDM:** The engineering principles for broadcasting the complex, multi-frequency signals wirelessly and efficiently.

This method bypasses the impossible challenge of focusing an external field by embedding the focus and selectivity directly into the target itself.
